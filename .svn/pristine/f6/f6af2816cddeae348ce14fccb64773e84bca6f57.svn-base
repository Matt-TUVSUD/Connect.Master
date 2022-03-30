
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/3/2020 4:37:22 PM
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
    ' Encapsulates the 'viewCCPSRecommendationGrid' view
    ' </summary>

    <System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _
    <Serializable> _
    <DataContract> _
    <KnownType(GetType(ViewCCPSRecommendationGrid))> _
    <XmlType("ViewCCPSRecommendationGrid")> _
    Partial Public Class ViewCCPSRecommendationGrid
        Inherits esViewCCPSRecommendationGrid

        <DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _
        Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
            Get
                Return MyBase.Debug
            End Get
        End Property

        Public Overrides Function CreateInstance() As esEntity
            Return New ViewCCPSRecommendationGrid()
        End Function

#Region "Static Quick Access Methods"

#End Region



    End Class



    <DebuggerDisplay("Count = {Count}")> _
    <Serializable> _
    <CollectionDataContract> _
    <XmlType("ViewCCPSRecommendationGridCollection")> _
    Partial Public Class ViewCCPSRecommendationGridCollection
        Inherits esViewCCPSRecommendationGridCollection
        Implements IEnumerable(Of ViewCCPSRecommendationGrid)




#Region "WCF Service Class"

        <DataContract> _
        <KnownType(GetType(ViewCCPSRecommendationGrid))> _
        Public Class ViewCCPSRecommendationGridCollectionWCFPacket
            Inherits esCollectionWCFPacket(Of ViewCCPSRecommendationGridCollection)

            Public Shared Widening Operator CType(packet As ViewCCPSRecommendationGridCollectionWCFPacket) As ViewCCPSRecommendationGridCollection
                Return packet.Collection
            End Operator

            Public Shared Widening Operator CType(collection As ViewCCPSRecommendationGridCollection) As ViewCCPSRecommendationGridCollectionWCFPacket
                Return New ViewCCPSRecommendationGridCollectionWCFPacket() With {.Collection = collection}
            End Operator

        End Class

#End Region



    End Class




    <DebuggerDisplay("Query = {Parse()}")> _
    <Serializable> _
    Partial Public Class ViewCCPSRecommendationGridQuery
        Inherits esViewCCPSRecommendationGridQuery

        Public Sub New(ByVal joinAlias As String)
            Me.es.JoinAlias = joinAlias
        End Sub

        Protected Overrides Function GetQueryName() As String
            Return "ViewCCPSRecommendationGridQuery"
        End Function

#Region "Explicit Casts"

        Public Shared Narrowing Operator CType(ByVal query As ViewCCPSRecommendationGridQuery) As String
            Return ViewCCPSRecommendationGridQuery.SerializeHelper.ToXml(query)
        End Operator

        Public Shared Narrowing Operator CType(ByVal query As String) As ViewCCPSRecommendationGridQuery
            Return DirectCast(ViewCCPSRecommendationGridQuery.SerializeHelper.FromXml(query, GetType(ViewCCPSRecommendationGridQuery)), ViewCCPSRecommendationGridQuery)
        End Operator

#End Region

    End Class


    <DataContract> _
    <Serializable()> _
    Partial Public MustInherit Class esViewCCPSRecommendationGrid
        Inherits esEntity
        Implements INotifyPropertyChanged

        Public Sub New()

        End Sub

#Region "LoadByPrimaryKey"

#End Region

#Region "Properties"



        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.FileNo
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property FileNo As System.String
            Get
                Return MyBase.GetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.FileNo)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.FileNo, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.FileNo)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.RecYear
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property RecYear As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(ViewCCPSRecommendationGridMetadata.ColumnNames.RecYear)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(ViewCCPSRecommendationGridMetadata.ColumnNames.RecYear, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.RecYear)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.RecMo
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property RecMo As System.String
            Get
                Return MyBase.GetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.RecMo)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.RecMo, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.RecMo)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.RecNumber
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property RecNumber As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(ViewCCPSRecommendationGridMetadata.ColumnNames.RecNumber)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(ViewCCPSRecommendationGridMetadata.ColumnNames.RecNumber, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.RecNumber)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.RecSubLetter
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property RecSubLetter As System.String
            Get
                Return MyBase.GetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.RecSubLetter)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.RecSubLetter, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.RecSubLetter)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.RecStatus
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property RecStatus As System.String
            Get
                Return MyBase.GetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.RecStatus)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.RecStatus, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.RecStatus)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.StatusDate
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property StatusDate As Nullable(Of System.DateTime)
            Get
                Return MyBase.GetSystemDateTime(ViewCCPSRecommendationGridMetadata.ColumnNames.StatusDate)
            End Get

            Set(ByVal value As Nullable(Of System.DateTime))
                If MyBase.SetSystemDateTime(ViewCCPSRecommendationGridMetadata.ColumnNames.StatusDate, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.StatusDate)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.RecCode
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property RecCode As System.String
            Get
                Return MyBase.GetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.RecCode)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.RecCode, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.RecCode)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.RecImpact
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property RecImpact As System.String
            Get
                Return MyBase.GetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.RecImpact)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.RecImpact, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.RecImpact)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.Hazard
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property Hazard As System.String
            Get
                Return MyBase.GetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.Hazard)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.Hazard, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.Hazard)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.PrimaryRecType
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property PrimaryRecType As System.String
            Get
                Return MyBase.GetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.PrimaryRecType)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.PrimaryRecType, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.PrimaryRecType)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.SecondaryRecType
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property SecondaryRecType As System.String
            Get
                Return MyBase.GetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.SecondaryRecType)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.SecondaryRecType, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.SecondaryRecType)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.RecKeywords
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property RecKeywords As System.String
            Get
                Return MyBase.GetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.RecKeywords)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.RecKeywords, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.RecKeywords)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.Current_LE_Actual
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property CurrentLEActual As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(ViewCCPSRecommendationGridMetadata.ColumnNames.CurrentLEActual)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(ViewCCPSRecommendationGridMetadata.ColumnNames.CurrentLEActual, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.CurrentLEActual)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.Current_LE_Range
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property CurrentLERange As System.String
            Get
                Return MyBase.GetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.CurrentLERange)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.CurrentLERange, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.CurrentLERange)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.Completed_LE_Actual
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property CompletedLEActual As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(ViewCCPSRecommendationGridMetadata.ColumnNames.CompletedLEActual)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(ViewCCPSRecommendationGridMetadata.ColumnNames.CompletedLEActual, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.CompletedLEActual)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.Completed_LE_Range
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property CompletedLERange As System.String
            Get
                Return MyBase.GetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.CompletedLERange)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.CompletedLERange, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.CompletedLERange)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.Est_CostToComplete_Actual
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property EstCostToCompleteActual As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(ViewCCPSRecommendationGridMetadata.ColumnNames.EstCostToCompleteActual)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(ViewCCPSRecommendationGridMetadata.ColumnNames.EstCostToCompleteActual, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.EstCostToCompleteActual)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.Est_CostToComplete_Range
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property EstCostToCompleteRange As System.String
            Get
                Return MyBase.GetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.EstCostToCompleteRange)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.EstCostToCompleteRange, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.EstCostToCompleteRange)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.Actual_CostToComplete
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property ActualCostToComplete As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(ViewCCPSRecommendationGridMetadata.ColumnNames.ActualCostToComplete)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(ViewCCPSRecommendationGridMetadata.ColumnNames.ActualCostToComplete, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.ActualCostToComplete)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.ExpdComplDate
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property ExpdComplDate As Nullable(Of System.DateTime)
            Get
                Return MyBase.GetSystemDateTime(ViewCCPSRecommendationGridMetadata.ColumnNames.ExpdComplDate)
            End Get

            Set(ByVal value As Nullable(Of System.DateTime))
                If MyBase.SetSystemDateTime(ViewCCPSRecommendationGridMetadata.ColumnNames.ExpdComplDate, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.ExpdComplDate)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.SavingsRatio
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property SavingsRatio As Nullable(Of System.Double)
            Get
                Return MyBase.GetSystemDouble(ViewCCPSRecommendationGridMetadata.ColumnNames.SavingsRatio)
            End Get

            Set(ByVal value As Nullable(Of System.Double))
                If MyBase.SetSystemDouble(ViewCCPSRecommendationGridMetadata.ColumnNames.SavingsRatio, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.SavingsRatio)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.IntendedAction
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property IntendedAction As System.String
            Get
                Return MyBase.GetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.IntendedAction)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.IntendedAction, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.IntendedAction)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.RespDate
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property RespDate As Nullable(Of System.DateTime)
            Get
                Return MyBase.GetSystemDateTime(ViewCCPSRecommendationGridMetadata.ColumnNames.RespDate)
            End Get

            Set(ByVal value As Nullable(Of System.DateTime))
                If MyBase.SetSystemDateTime(ViewCCPSRecommendationGridMetadata.ColumnNames.RespDate, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.RespDate)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.RespFrom
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property RespFrom As System.String
            Get
                Return MyBase.GetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.RespFrom)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.RespFrom, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.RespFrom)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.FacilityComment
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property FacilityComment As System.String
            Get
                Return MyBase.GetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.FacilityComment)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.FacilityComment, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.FacilityComment)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.MgmtRespAction
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property MgmtRespAction As System.String
            Get
                Return MyBase.GetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.MgmtRespAction)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.MgmtRespAction, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.MgmtRespAction)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.MgmtRespDate
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property MgmtRespDate As Nullable(Of System.DateTime)
            Get
                Return MyBase.GetSystemDateTime(ViewCCPSRecommendationGridMetadata.ColumnNames.MgmtRespDate)
            End Get

            Set(ByVal value As Nullable(Of System.DateTime))
                If MyBase.SetSystemDateTime(ViewCCPSRecommendationGridMetadata.ColumnNames.MgmtRespDate, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.MgmtRespDate)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.MgmtRespFrom
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property MgmtRespFrom As System.String
            Get
                Return MyBase.GetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.MgmtRespFrom)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.MgmtRespFrom, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.MgmtRespFrom)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.MgmtRespComment
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property MgmtRespComment As System.String
            Get
                Return MyBase.GetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.MgmtRespComment)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.MgmtRespComment, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.MgmtRespComment)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.ThirdLevelRespAction
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property ThirdLevelRespAction As System.String
            Get
                Return MyBase.GetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.ThirdLevelRespAction)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.ThirdLevelRespAction, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.ThirdLevelRespAction)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.ThirdLevelRespDate
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property ThirdLevelRespDate As Nullable(Of System.DateTime)
            Get
                Return MyBase.GetSystemDateTime(ViewCCPSRecommendationGridMetadata.ColumnNames.ThirdLevelRespDate)
            End Get

            Set(ByVal value As Nullable(Of System.DateTime))
                If MyBase.SetSystemDateTime(ViewCCPSRecommendationGridMetadata.ColumnNames.ThirdLevelRespDate, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.ThirdLevelRespDate)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.ThirdLevelRespFrom
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property ThirdLevelRespFrom As System.String
            Get
                Return MyBase.GetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.ThirdLevelRespFrom)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.ThirdLevelRespFrom, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.ThirdLevelRespFrom)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to viewCCPSRecommendationGrid.ThirdLevelRespComment
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property ThirdLevelRespComment As System.String
            Get
                Return MyBase.GetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.ThirdLevelRespComment)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(ViewCCPSRecommendationGridMetadata.ColumnNames.ThirdLevelRespComment, value) Then
                    OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.ThirdLevelRespComment)
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

                        Case "RecYear"
                            Me.str().RecYear = CType(value, String)

                        Case "RecMo"
                            Me.str().RecMo = CType(value, String)

                        Case "RecNumber"
                            Me.str().RecNumber = CType(value, String)

                        Case "RecSubLetter"
                            Me.str().RecSubLetter = CType(value, String)

                        Case "RecStatus"
                            Me.str().RecStatus = CType(value, String)

                        Case "StatusDate"
                            Me.str().StatusDate = CType(value, String)

                        Case "RecCode"
                            Me.str().RecCode = CType(value, String)

                        Case "RecImpact"
                            Me.str().RecImpact = CType(value, String)

                        Case "Hazard"
                            Me.str().Hazard = CType(value, String)

                        Case "PrimaryRecType"
                            Me.str().PrimaryRecType = CType(value, String)

                        Case "SecondaryRecType"
                            Me.str().SecondaryRecType = CType(value, String)

                        Case "RecKeywords"
                            Me.str().RecKeywords = CType(value, String)

                        Case "CurrentLEActual"
                            Me.str().CurrentLEActual = CType(value, String)

                        Case "CurrentLERange"
                            Me.str().CurrentLERange = CType(value, String)

                        Case "CompletedLEActual"
                            Me.str().CompletedLEActual = CType(value, String)

                        Case "CompletedLERange"
                            Me.str().CompletedLERange = CType(value, String)

                        Case "EstCostToCompleteActual"
                            Me.str().EstCostToCompleteActual = CType(value, String)

                        Case "EstCostToCompleteRange"
                            Me.str().EstCostToCompleteRange = CType(value, String)

                        Case "ActualCostToComplete"
                            Me.str().ActualCostToComplete = CType(value, String)

                        Case "ExpdComplDate"
                            Me.str().ExpdComplDate = CType(value, String)

                        Case "SavingsRatio"
                            Me.str().SavingsRatio = CType(value, String)

                        Case "IntendedAction"
                            Me.str().IntendedAction = CType(value, String)

                        Case "RespDate"
                            Me.str().RespDate = CType(value, String)

                        Case "RespFrom"
                            Me.str().RespFrom = CType(value, String)

                        Case "FacilityComment"
                            Me.str().FacilityComment = CType(value, String)

                        Case "MgmtRespAction"
                            Me.str().MgmtRespAction = CType(value, String)

                        Case "MgmtRespDate"
                            Me.str().MgmtRespDate = CType(value, String)

                        Case "MgmtRespFrom"
                            Me.str().MgmtRespFrom = CType(value, String)

                        Case "MgmtRespComment"
                            Me.str().MgmtRespComment = CType(value, String)

                        Case "ThirdLevelRespAction"
                            Me.str().ThirdLevelRespAction = CType(value, String)

                        Case "ThirdLevelRespDate"
                            Me.str().ThirdLevelRespDate = CType(value, String)

                        Case "ThirdLevelRespFrom"
                            Me.str().ThirdLevelRespFrom = CType(value, String)

                        Case "ThirdLevelRespComment"
                            Me.str().ThirdLevelRespComment = CType(value, String)

                    End Select

                Else

                    Select Case name

                        Case "RecYear"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.RecYear = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.RecYear)
                            End If

                        Case "RecNumber"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.RecNumber = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.RecNumber)
                            End If

                        Case "StatusDate"

                            If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
                                Me.StatusDate = CType(value, Nullable(Of System.DateTime))
                                OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.StatusDate)
                            End If

                        Case "CurrentLEActual"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.CurrentLEActual = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.CurrentLEActual)
                            End If

                        Case "CompletedLEActual"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.CompletedLEActual = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.CompletedLEActual)
                            End If

                        Case "EstCostToCompleteActual"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.EstCostToCompleteActual = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.EstCostToCompleteActual)
                            End If

                        Case "ActualCostToComplete"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.ActualCostToComplete = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.ActualCostToComplete)
                            End If

                        Case "ExpdComplDate"

                            If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
                                Me.ExpdComplDate = CType(value, Nullable(Of System.DateTime))
                                OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.ExpdComplDate)
                            End If

                        Case "SavingsRatio"

                            If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
                                Me.SavingsRatio = CType(value, Nullable(Of System.Double))
                                OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.SavingsRatio)
                            End If

                        Case "RespDate"

                            If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
                                Me.RespDate = CType(value, Nullable(Of System.DateTime))
                                OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.RespDate)
                            End If

                        Case "MgmtRespDate"

                            If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
                                Me.MgmtRespDate = CType(value, Nullable(Of System.DateTime))
                                OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.MgmtRespDate)
                            End If

                        Case "ThirdLevelRespDate"

                            If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
                                Me.ThirdLevelRespDate = CType(value, Nullable(Of System.DateTime))
                                OnPropertyChanged(ViewCCPSRecommendationGridMetadata.PropertyNames.ThirdLevelRespDate)
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

            Public Sub New(ByVal entity As esViewCCPSRecommendationGrid)
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

            Public Property RecMo As System.String
                Get
                    Dim data_ As System.String = entity.RecMo

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.RecMo = Nothing
                    Else
                        entity.RecMo = Convert.ToString(Value)
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

            Public Property RecSubLetter As System.String
                Get
                    Dim data_ As System.String = entity.RecSubLetter

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.RecSubLetter = Nothing
                    Else
                        entity.RecSubLetter = Convert.ToString(Value)
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

            Public Property RecCode As System.String
                Get
                    Dim data_ As System.String = entity.RecCode

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.RecCode = Nothing
                    Else
                        entity.RecCode = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property RecImpact As System.String
                Get
                    Dim data_ As System.String = entity.RecImpact

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.RecImpact = Nothing
                    Else
                        entity.RecImpact = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property Hazard As System.String
                Get
                    Dim data_ As System.String = entity.Hazard

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.Hazard = Nothing
                    Else
                        entity.Hazard = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property PrimaryRecType As System.String
                Get
                    Dim data_ As System.String = entity.PrimaryRecType

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.PrimaryRecType = Nothing
                    Else
                        entity.PrimaryRecType = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property SecondaryRecType As System.String
                Get
                    Dim data_ As System.String = entity.SecondaryRecType

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.SecondaryRecType = Nothing
                    Else
                        entity.SecondaryRecType = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property RecKeywords As System.String
                Get
                    Dim data_ As System.String = entity.RecKeywords

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.RecKeywords = Nothing
                    Else
                        entity.RecKeywords = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property CurrentLEActual As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.CurrentLEActual

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.CurrentLEActual = Nothing
                    Else
                        entity.CurrentLEActual = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property CurrentLERange As System.String
                Get
                    Dim data_ As System.String = entity.CurrentLERange

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.CurrentLERange = Nothing
                    Else
                        entity.CurrentLERange = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property CompletedLEActual As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.CompletedLEActual

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.CompletedLEActual = Nothing
                    Else
                        entity.CompletedLEActual = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property CompletedLERange As System.String
                Get
                    Dim data_ As System.String = entity.CompletedLERange

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.CompletedLERange = Nothing
                    Else
                        entity.CompletedLERange = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property EstCostToCompleteActual As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.EstCostToCompleteActual

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.EstCostToCompleteActual = Nothing
                    Else
                        entity.EstCostToCompleteActual = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property EstCostToCompleteRange As System.String
                Get
                    Dim data_ As System.String = entity.EstCostToCompleteRange

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.EstCostToCompleteRange = Nothing
                    Else
                        entity.EstCostToCompleteRange = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property ActualCostToComplete As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.ActualCostToComplete

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.ActualCostToComplete = Nothing
                    Else
                        entity.ActualCostToComplete = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property ExpdComplDate As System.String
                Get
                    Dim data_ As Nullable(Of System.DateTime) = entity.ExpdComplDate

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.ExpdComplDate = Nothing
                    Else
                        entity.ExpdComplDate = Convert.ToDateTime(Value)
                    End If
                End Set
            End Property

            Public Property SavingsRatio As System.String
                Get
                    Dim data_ As Nullable(Of System.Double) = entity.SavingsRatio

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.SavingsRatio = Nothing
                    Else
                        entity.SavingsRatio = Convert.ToDouble(Value)
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

            Public Property RespDate As System.String
                Get
                    Dim data_ As Nullable(Of System.DateTime) = entity.RespDate

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.RespDate = Nothing
                    Else
                        entity.RespDate = Convert.ToDateTime(Value)
                    End If
                End Set
            End Property

            Public Property RespFrom As System.String
                Get
                    Dim data_ As System.String = entity.RespFrom

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.RespFrom = Nothing
                    Else
                        entity.RespFrom = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property FacilityComment As System.String
                Get
                    Dim data_ As System.String = entity.FacilityComment

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.FacilityComment = Nothing
                    Else
                        entity.FacilityComment = Convert.ToString(Value)
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


            Private entity As esViewCCPSRecommendationGrid
        End Class


        <NonSerialized> _
        <IgnoreDataMember> _
              Private _esstrings As esStrings

#End Region

#Region "Housekeeping methods"

        Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
            Get
                Return ViewCCPSRecommendationGridMetadata.Meta()
            End Get
        End Property

#End Region

#Region "Query Logic"

        Public ReadOnly Property Query() As ViewCCPSRecommendationGridQuery
            Get
                If Me.m_query Is Nothing Then
                    Me.m_query = New ViewCCPSRecommendationGridQuery()
                    InitQuery(Me.m_query)
                End If

                Return Me.m_query
            End Get
        End Property

        Public Overloads Function Load(ByVal query As ViewCCPSRecommendationGridQuery) As Boolean
            Me.m_query = query
            InitQuery(Me.m_query)
            Return Me.Query.Load()
        End Function

        Protected Sub InitQuery(ByVal query As ViewCCPSRecommendationGridQuery)
            query.OnLoadDelegate = AddressOf OnQueryLoaded

            If Not query.es2.HasConnection Then
                query.es2.Connection = DirectCast(Me, IEntity).Connection
            End If
        End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As ViewCCPSRecommendationGridQuery

    End Class



    <Serializable()> _
    Partial Public MustInherit Class esViewCCPSRecommendationGridCollection
        Inherits esEntityCollection(Of ViewCCPSRecommendationGrid)

#Region "Housekeeping methods"
        Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
            Get
                Return ViewCCPSRecommendationGridMetadata.Meta()
            End Get
        End Property

        Protected Overloads Overrides Function GetCollectionName() As String
            Return "ViewCCPSRecommendationGridCollection"
        End Function

#End Region

#Region "Query Logic"


        <BrowsableAttribute(False)> _
        Public ReadOnly Property Query() As ViewCCPSRecommendationGridQuery
            Get
                If Me.m_query Is Nothing Then
                    Me.m_query = New ViewCCPSRecommendationGridQuery()
                    InitQuery(Me.m_query)
                End If

                Return Me.m_query
            End Get
        End Property

        Public Overloads Function Load(ByVal query As ViewCCPSRecommendationGridQuery) As Boolean
            Me.m_query = query
            InitQuery(Me.m_query)
            Return Query.Load()
        End Function

        Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
            If Me.m_query Is Nothing Then
                Me.m_query = New ViewCCPSRecommendationGridQuery()
                Me.InitQuery(m_query)
            End If
            Return Me.m_query
        End Function

        Protected Sub InitQuery(ByVal query As ViewCCPSRecommendationGridQuery)
            query.OnLoadDelegate = AddressOf OnQueryLoaded

            If Not query.es2.HasConnection Then
                query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
            End If
        End Sub

        Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
            Me.InitQuery(DirectCast(query, ViewCCPSRecommendationGridQuery))
        End Sub

#End Region

        Private m_query As ViewCCPSRecommendationGridQuery
    End Class



    <Serializable> _
    Partial Public MustInherit Class esViewCCPSRecommendationGridQuery
        Inherits esDynamicQuery

        Protected Overrides ReadOnly Property Meta() As IMetadata
            Get
                Return ViewCCPSRecommendationGridMetadata.Meta()
            End Get
        End Property

#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
                Case "FileNo"
                    Return Me.FileNo
                Case "RecYear"
                    Return Me.RecYear
                Case "RecMo"
                    Return Me.RecMo
                Case "RecNumber"
                    Return Me.RecNumber
                Case "RecSubLetter"
                    Return Me.RecSubLetter
                Case "RecStatus"
                    Return Me.RecStatus
                Case "StatusDate"
                    Return Me.StatusDate
                Case "RecCode"
                    Return Me.RecCode
                Case "RecImpact"
                    Return Me.RecImpact
                Case "Hazard"
                    Return Me.Hazard
                Case "PrimaryRecType"
                    Return Me.PrimaryRecType
                Case "SecondaryRecType"
                    Return Me.SecondaryRecType
                Case "RecKeywords"
                    Return Me.RecKeywords
                Case "CurrentLEActual"
                    Return Me.CurrentLEActual
                Case "CurrentLERange"
                    Return Me.CurrentLERange
                Case "CompletedLEActual"
                    Return Me.CompletedLEActual
                Case "CompletedLERange"
                    Return Me.CompletedLERange
                Case "EstCostToCompleteActual"
                    Return Me.EstCostToCompleteActual
                Case "EstCostToCompleteRange"
                    Return Me.EstCostToCompleteRange
                Case "ActualCostToComplete"
                    Return Me.ActualCostToComplete
                Case "ExpdComplDate"
                    Return Me.ExpdComplDate
                Case "SavingsRatio"
                    Return Me.SavingsRatio
                Case "IntendedAction"
                    Return Me.IntendedAction
                Case "RespDate"
                    Return Me.RespDate
                Case "RespFrom"
                    Return Me.RespFrom
                Case "FacilityComment"
                    Return Me.FacilityComment
                Case "MgmtRespAction"
                    Return Me.MgmtRespAction
                Case "MgmtRespDate"
                    Return Me.MgmtRespDate
                Case "MgmtRespFrom"
                    Return Me.MgmtRespFrom
                Case "MgmtRespComment"
                    Return Me.MgmtRespComment
                Case "ThirdLevelRespAction"
                    Return Me.ThirdLevelRespAction
                Case "ThirdLevelRespDate"
                    Return Me.ThirdLevelRespDate
                Case "ThirdLevelRespFrom"
                    Return Me.ThirdLevelRespFrom
                Case "ThirdLevelRespComment"
                    Return Me.ThirdLevelRespComment
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region

#Region "esQueryItems"


        Public ReadOnly Property FileNo As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.FileNo, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property RecYear As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.RecYear, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property RecMo As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.RecMo, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property RecNumber As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.RecNumber, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property RecSubLetter As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.RecSubLetter, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property RecStatus As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.RecStatus, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property StatusDate As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.StatusDate, esSystemType.DateTime)
            End Get
        End Property

        Public ReadOnly Property RecCode As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.RecCode, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property RecImpact As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.RecImpact, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property Hazard As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.Hazard, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property PrimaryRecType As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.PrimaryRecType, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property SecondaryRecType As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.SecondaryRecType, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property RecKeywords As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.RecKeywords, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property CurrentLEActual As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.CurrentLEActual, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property CurrentLERange As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.CurrentLERange, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property CompletedLEActual As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.CompletedLEActual, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property CompletedLERange As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.CompletedLERange, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property EstCostToCompleteActual As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.EstCostToCompleteActual, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property EstCostToCompleteRange As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.EstCostToCompleteRange, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property ActualCostToComplete As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.ActualCostToComplete, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property ExpdComplDate As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.ExpdComplDate, esSystemType.DateTime)
            End Get
        End Property

        Public ReadOnly Property SavingsRatio As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.SavingsRatio, esSystemType.Double)
            End Get
        End Property

        Public ReadOnly Property IntendedAction As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.IntendedAction, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property RespDate As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.RespDate, esSystemType.DateTime)
            End Get
        End Property

        Public ReadOnly Property RespFrom As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.RespFrom, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property FacilityComment As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.FacilityComment, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property MgmtRespAction As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.MgmtRespAction, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property MgmtRespDate As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.MgmtRespDate, esSystemType.DateTime)
            End Get
        End Property

        Public ReadOnly Property MgmtRespFrom As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.MgmtRespFrom, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property MgmtRespComment As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.MgmtRespComment, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property ThirdLevelRespAction As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.ThirdLevelRespAction, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property ThirdLevelRespDate As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.ThirdLevelRespDate, esSystemType.DateTime)
            End Get
        End Property

        Public ReadOnly Property ThirdLevelRespFrom As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.ThirdLevelRespFrom, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property ThirdLevelRespComment As esQueryItem
            Get
                Return New esQueryItem(Me, ViewCCPSRecommendationGridMetadata.ColumnNames.ThirdLevelRespComment, esSystemType.String)
            End Get
        End Property

#End Region

    End Class



    <Serializable> _
    Partial Public Class ViewCCPSRecommendationGridMetadata
        Inherits esMetadata
        Implements IMetadata

#Region "Protected Constructor"
        Protected Sub New()
            m_columns = New esColumnMetadataCollection()
            Dim c As esColumnMetadata

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.FileNo, 0, GetType(System.String), esSystemType.String)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.FileNo
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.RecYear, 1, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.RecYear
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.RecMo, 2, GetType(System.String), esSystemType.String)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.RecMo
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.RecNumber, 3, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.RecNumber
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.RecSubLetter, 4, GetType(System.String), esSystemType.String)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.RecSubLetter
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.RecStatus, 5, GetType(System.String), esSystemType.String)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.RecStatus
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.StatusDate, 6, GetType(System.DateTime), esSystemType.DateTime)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.StatusDate
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.RecCode, 7, GetType(System.String), esSystemType.String)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.RecCode
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.RecImpact, 8, GetType(System.String), esSystemType.String)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.RecImpact
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.Hazard, 9, GetType(System.String), esSystemType.String)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.Hazard
            c.CharacterMaxLength = 6
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.PrimaryRecType, 10, GetType(System.String), esSystemType.String)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.PrimaryRecType
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.SecondaryRecType, 11, GetType(System.String), esSystemType.String)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.SecondaryRecType
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.RecKeywords, 12, GetType(System.String), esSystemType.String)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.RecKeywords
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.CurrentLEActual, 13, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.CurrentLEActual
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.CurrentLERange, 14, GetType(System.String), esSystemType.String)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.CurrentLERange
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.CompletedLEActual, 15, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.CompletedLEActual
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.CompletedLERange, 16, GetType(System.String), esSystemType.String)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.CompletedLERange
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.EstCostToCompleteActual, 17, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.EstCostToCompleteActual
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.EstCostToCompleteRange, 18, GetType(System.String), esSystemType.String)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.EstCostToCompleteRange
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.ActualCostToComplete, 19, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.ActualCostToComplete
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.ExpdComplDate, 20, GetType(System.DateTime), esSystemType.DateTime)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.ExpdComplDate
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.SavingsRatio, 21, GetType(System.Double), esSystemType.Double)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.SavingsRatio
            c.NumericPrecision = 15
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.IntendedAction, 22, GetType(System.String), esSystemType.String)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.IntendedAction
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.RespDate, 23, GetType(System.DateTime), esSystemType.DateTime)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.RespDate
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.RespFrom, 24, GetType(System.String), esSystemType.String)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.RespFrom
            c.CharacterMaxLength = 75
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.FacilityComment, 25, GetType(System.String), esSystemType.String)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.FacilityComment
            c.CharacterMaxLength = 8000
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.MgmtRespAction, 26, GetType(System.String), esSystemType.String)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.MgmtRespAction
            c.CharacterMaxLength = 75
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.MgmtRespDate, 27, GetType(System.DateTime), esSystemType.DateTime)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.MgmtRespDate
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.MgmtRespFrom, 28, GetType(System.String), esSystemType.String)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.MgmtRespFrom
            c.CharacterMaxLength = 75
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.MgmtRespComment, 29, GetType(System.String), esSystemType.String)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.MgmtRespComment
            c.CharacterMaxLength = 2147483647
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.ThirdLevelRespAction, 30, GetType(System.String), esSystemType.String)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.ThirdLevelRespAction
            c.CharacterMaxLength = 75
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.ThirdLevelRespDate, 31, GetType(System.DateTime), esSystemType.DateTime)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.ThirdLevelRespDate
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.ThirdLevelRespFrom, 32, GetType(System.String), esSystemType.String)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.ThirdLevelRespFrom
            c.CharacterMaxLength = 75
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(ViewCCPSRecommendationGridMetadata.ColumnNames.ThirdLevelRespComment, 33, GetType(System.String), esSystemType.String)
            c.PropertyName = ViewCCPSRecommendationGridMetadata.PropertyNames.ThirdLevelRespComment
            c.CharacterMaxLength = 75
            c.IsNullable = True
            m_columns.Add(c)

        End Sub
#End Region

        Public Shared Function Meta() As ViewCCPSRecommendationGridMetadata
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
            Public Const RecYear As String = "RecYear"
            Public Const RecMo As String = "RecMo"
            Public Const RecNumber As String = "RecNumber"
            Public Const RecSubLetter As String = "RecSubLetter"
            Public Const RecStatus As String = "RecStatus"
            Public Const StatusDate As String = "StatusDate"
            Public Const RecCode As String = "RecCode"
            Public Const RecImpact As String = "RecImpact"
            Public Const Hazard As String = "Hazard"
            Public Const PrimaryRecType As String = "PrimaryRecType"
            Public Const SecondaryRecType As String = "SecondaryRecType"
            Public Const RecKeywords As String = "RecKeywords"
            Public Const CurrentLEActual As String = "Current_LE_Actual"
            Public Const CurrentLERange As String = "Current_LE_Range"
            Public Const CompletedLEActual As String = "Completed_LE_Actual"
            Public Const CompletedLERange As String = "Completed_LE_Range"
            Public Const EstCostToCompleteActual As String = "Est_CostToComplete_Actual"
            Public Const EstCostToCompleteRange As String = "Est_CostToComplete_Range"
            Public Const ActualCostToComplete As String = "Actual_CostToComplete"
            Public Const ExpdComplDate As String = "ExpdComplDate"
            Public Const SavingsRatio As String = "SavingsRatio"
            Public Const IntendedAction As String = "IntendedAction"
            Public Const RespDate As String = "RespDate"
            Public Const RespFrom As String = "RespFrom"
            Public Const FacilityComment As String = "FacilityComment"
            Public Const MgmtRespAction As String = "MgmtRespAction"
            Public Const MgmtRespDate As String = "MgmtRespDate"
            Public Const MgmtRespFrom As String = "MgmtRespFrom"
            Public Const MgmtRespComment As String = "MgmtRespComment"
            Public Const ThirdLevelRespAction As String = "ThirdLevelRespAction"
            Public Const ThirdLevelRespDate As String = "ThirdLevelRespDate"
            Public Const ThirdLevelRespFrom As String = "ThirdLevelRespFrom"
            Public Const ThirdLevelRespComment As String = "ThirdLevelRespComment"
        End Class
#End Region

#Region "PropertyNames"
        Public Class PropertyNames
            Public Const FileNo As String = "FileNo"
            Public Const RecYear As String = "RecYear"
            Public Const RecMo As String = "RecMo"
            Public Const RecNumber As String = "RecNumber"
            Public Const RecSubLetter As String = "RecSubLetter"
            Public Const RecStatus As String = "RecStatus"
            Public Const StatusDate As String = "StatusDate"
            Public Const RecCode As String = "RecCode"
            Public Const RecImpact As String = "RecImpact"
            Public Const Hazard As String = "Hazard"
            Public Const PrimaryRecType As String = "PrimaryRecType"
            Public Const SecondaryRecType As String = "SecondaryRecType"
            Public Const RecKeywords As String = "RecKeywords"
            Public Const CurrentLEActual As String = "CurrentLEActual"
            Public Const CurrentLERange As String = "CurrentLERange"
            Public Const CompletedLEActual As String = "CompletedLEActual"
            Public Const CompletedLERange As String = "CompletedLERange"
            Public Const EstCostToCompleteActual As String = "EstCostToCompleteActual"
            Public Const EstCostToCompleteRange As String = "EstCostToCompleteRange"
            Public Const ActualCostToComplete As String = "ActualCostToComplete"
            Public Const ExpdComplDate As String = "ExpdComplDate"
            Public Const SavingsRatio As String = "SavingsRatio"
            Public Const IntendedAction As String = "IntendedAction"
            Public Const RespDate As String = "RespDate"
            Public Const RespFrom As String = "RespFrom"
            Public Const FacilityComment As String = "FacilityComment"
            Public Const MgmtRespAction As String = "MgmtRespAction"
            Public Const MgmtRespDate As String = "MgmtRespDate"
            Public Const MgmtRespFrom As String = "MgmtRespFrom"
            Public Const MgmtRespComment As String = "MgmtRespComment"
            Public Const ThirdLevelRespAction As String = "ThirdLevelRespAction"
            Public Const ThirdLevelRespDate As String = "ThirdLevelRespDate"
            Public Const ThirdLevelRespFrom As String = "ThirdLevelRespFrom"
            Public Const ThirdLevelRespComment As String = "ThirdLevelRespComment"
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
            SyncLock GetType(ViewCCPSRecommendationGridMetadata)

                If ViewCCPSRecommendationGridMetadata.mapDelegates Is Nothing Then
                    ViewCCPSRecommendationGridMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
                End If

                If ViewCCPSRecommendationGridMetadata._meta Is Nothing Then
                    ViewCCPSRecommendationGridMetadata._meta = New ViewCCPSRecommendationGridMetadata()
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



                meta.AddTypeMap("FileNo", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("RecYear", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("RecMo", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("RecNumber", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("RecSubLetter", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("RecStatus", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("StatusDate", New esTypeMap("smalldatetime", "System.DateTime"))
                meta.AddTypeMap("RecCode", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("RecImpact", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("Hazard", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("PrimaryRecType", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("SecondaryRecType", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("RecKeywords", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("CurrentLEActual", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("CurrentLERange", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("CompletedLEActual", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("CompletedLERange", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("EstCostToCompleteActual", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("EstCostToCompleteRange", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("ActualCostToComplete", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("ExpdComplDate", New esTypeMap("smalldatetime", "System.DateTime"))
                meta.AddTypeMap("SavingsRatio", New esTypeMap("float", "System.Double"))
                meta.AddTypeMap("IntendedAction", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("RespDate", New esTypeMap("datetime", "System.DateTime"))
                meta.AddTypeMap("RespFrom", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("FacilityComment", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("MgmtRespAction", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("MgmtRespDate", New esTypeMap("datetime", "System.DateTime"))
                meta.AddTypeMap("MgmtRespFrom", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("MgmtRespComment", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("ThirdLevelRespAction", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("ThirdLevelRespDate", New esTypeMap("datetime", "System.DateTime"))
                meta.AddTypeMap("ThirdLevelRespFrom", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("ThirdLevelRespComment", New esTypeMap("varchar", "System.String"))

                meta.Schema = "dbo"

                meta.Source = "viewCCPSRecommendationGrid"
                meta.Destination = "viewCCPSRecommendationGrid"

                meta.spInsert = "proc_viewCCPSRecommendationGridInsert"
                meta.spUpdate = "proc_viewCCPSRecommendationGridUpdate"
                meta.spDelete = "proc_viewCCPSRecommendationGridDelete"
                meta.spLoadAll = "proc_viewCCPSRecommendationGridLoadAll"
                meta.spLoadByPrimaryKey = "proc_viewCCPSRecommendationGridLoadByPrimaryKey"

                Me.m_providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me.m_providerMetadataMaps("esDefault")

        End Function

#End Region

        Private Shared _meta As ViewCCPSRecommendationGridMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
        Private Shared _esDefault As Integer = RegisterDelegateesDefault()

    End Class

End Namespace
