
'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/11/2017 3:30:36 PM
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
    ' Encapsulates the 'NavLink' table
    ' </summary>

    <System.Diagnostics.DebuggerDisplay("Data = {Debug}")> _
    <Serializable> _
    <DataContract> _
    <KnownType(GetType(NavLink))> _
    <XmlType("NavLink")> _
    Partial Public Class NavLink
        Inherits esNavLink

        <DebuggerBrowsable(DebuggerBrowsableState.RootHidden Or DebuggerBrowsableState.Never)> _
        Protected Overrides ReadOnly Property Debug() As esEntityDebuggerView()
            Get
                Return MyBase.Debug
            End Get
        End Property

        Public Overrides Function CreateInstance() As esEntity
            Return New NavLink()
        End Function

#Region "Static Quick Access Methods"
        Public Shared Sub Delete(ByVal navLinkId As System.Int32)
            Dim obj As New NavLink()
            obj.NavLinkId = navLinkId
            obj.AcceptChanges()
            obj.MarkAsDeleted()
            obj.Save()
        End Sub

        Public Shared Sub Delete(ByVal navLinkId As System.Int32, ByVal sqlAccessType As esSqlAccessType)
            Dim obj As New NavLink()
            obj.NavLinkId = navLinkId
            obj.AcceptChanges()
            obj.MarkAsDeleted()
            obj.Save(sqlAccessType)
        End Sub
#End Region



    End Class



    <DebuggerDisplay("Count = {Count}")> _
    <Serializable> _
    <CollectionDataContract> _
    <XmlType("NavLinkCollection")> _
    Partial Public Class NavLinkCollection
        Inherits esNavLinkCollection
        Implements IEnumerable(Of NavLink)

        Public Function FindByPrimaryKey(ByVal navLinkId As System.Int32) As NavLink
            Return MyBase.SingleOrDefault(Function(e) e.NavLinkId.HasValue AndAlso e.NavLinkId.Value = navLinkId)
        End Function



#Region "WCF Service Class"

        <DataContract> _
        <KnownType(GetType(NavLink))> _
        Public Class NavLinkCollectionWCFPacket
            Inherits esCollectionWCFPacket(Of NavLinkCollection)

            Public Shared Widening Operator CType(packet As NavLinkCollectionWCFPacket) As NavLinkCollection
                Return packet.Collection
            End Operator

            Public Shared Widening Operator CType(collection As NavLinkCollection) As NavLinkCollectionWCFPacket
                Return New NavLinkCollectionWCFPacket() With {.Collection = collection}
            End Operator

        End Class

#End Region



    End Class




    <DebuggerDisplay("Query = {Parse()}")> _
    <Serializable> _
    Partial Public Class NavLinkQuery
        Inherits esNavLinkQuery

        Public Sub New(ByVal joinAlias As String)
            Me.es.JoinAlias = joinAlias
        End Sub

        Protected Overrides Function GetQueryName() As String
            Return "NavLinkQuery"
        End Function

#Region "Explicit Casts"

        Public Shared Narrowing Operator CType(ByVal query As NavLinkQuery) As String
            Return NavLinkQuery.SerializeHelper.ToXml(query)
        End Operator

        Public Shared Narrowing Operator CType(ByVal query As String) As NavLinkQuery
            Return DirectCast(NavLinkQuery.SerializeHelper.FromXml(query, GetType(NavLinkQuery)), NavLinkQuery)
        End Operator

#End Region

    End Class


    <DataContract> _
    <Serializable()> _
    Partial Public MustInherit Class esNavLink
        Inherits esEntity
        Implements INotifyPropertyChanged

        Public Sub New()

        End Sub

#Region "LoadByPrimaryKey"
        Public Overridable Function LoadByPrimaryKey(ByVal navLinkId As System.Int32) As Boolean

            If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL Then
                Return LoadByPrimaryKeyDynamic(navLinkId)
            Else
                Return LoadByPrimaryKeyStoredProcedure(navLinkId)
            End If

        End Function

        Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal navLinkId As System.Int32) As Boolean

            If sqlAccessType = esSqlAccessType.DynamicSQL Then
                Return LoadByPrimaryKeyDynamic(navLinkId)
            Else
                Return LoadByPrimaryKeyStoredProcedure(navLinkId)
            End If

        End Function

        Private Function LoadByPrimaryKeyDynamic(ByVal navLinkId As System.Int32) As Boolean

            Dim query As New NavLinkQuery()
            query.Where(query.NavLinkId = navLinkId)
            Return Me.Load(query)

        End Function

        Private Function LoadByPrimaryKeyStoredProcedure(ByVal navLinkId As System.Int32) As Boolean

            Dim parms As esParameters = New esParameters()
            parms.Add("NavLinkId", navLinkId)

            Return MyBase.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)

        End Function
#End Region

#Region "Properties"



        ' <summary>
        ' Maps to NavLink.NavControlId
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavControlId As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(NavLinkMetadata.ColumnNames.NavControlId)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(NavLinkMetadata.ColumnNames.NavControlId, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavControlId)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavPracticeID
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavPracticeID As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(NavLinkMetadata.ColumnNames.NavPracticeID)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(NavLinkMetadata.ColumnNames.NavPracticeID, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavPracticeID)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavLevelId
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavLevelId As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(NavLinkMetadata.ColumnNames.NavLevelId)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(NavLinkMetadata.ColumnNames.NavLevelId, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavLevelId)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavParentLinkId
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavParentLinkId As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(NavLinkMetadata.ColumnNames.NavParentLinkId)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(NavLinkMetadata.ColumnNames.NavParentLinkId, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavParentLinkId)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavLinkId
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavLinkId As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(NavLinkMetadata.ColumnNames.NavLinkId)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(NavLinkMetadata.ColumnNames.NavLinkId, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavLinkId)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavText
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavText As System.String
            Get
                Return MyBase.GetSystemString(NavLinkMetadata.ColumnNames.NavText)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(NavLinkMetadata.ColumnNames.NavText, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavText)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavUrl
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavUrl As System.String
            Get
                Return MyBase.GetSystemString(NavLinkMetadata.ColumnNames.NavUrl)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(NavLinkMetadata.ColumnNames.NavUrl, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavUrl)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavOrder
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavOrder As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(NavLinkMetadata.ColumnNames.NavOrder)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(NavLinkMetadata.ColumnNames.NavOrder, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavOrder)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavToolTip
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavToolTip As System.String
            Get
                Return MyBase.GetSystemString(NavLinkMetadata.ColumnNames.NavToolTip)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(NavLinkMetadata.ColumnNames.NavToolTip, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavToolTip)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavVisible
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavVisible As Nullable(Of System.Boolean)
            Get
                Return MyBase.GetSystemBoolean(NavLinkMetadata.ColumnNames.NavVisible)
            End Get

            Set(ByVal value As Nullable(Of System.Boolean))
                If MyBase.SetSystemBoolean(NavLinkMetadata.ColumnNames.NavVisible, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavVisible)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavEnabled
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavEnabled As Nullable(Of System.Boolean)
            Get
                Return MyBase.GetSystemBoolean(NavLinkMetadata.ColumnNames.NavEnabled)
            End Get

            Set(ByVal value As Nullable(Of System.Boolean))
                If MyBase.SetSystemBoolean(NavLinkMetadata.ColumnNames.NavEnabled, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavEnabled)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavSpcFeature
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavSpcFeature As System.String
            Get
                Return MyBase.GetSystemString(NavLinkMetadata.ColumnNames.NavSpcFeature)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(NavLinkMetadata.ColumnNames.NavSpcFeature, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavSpcFeature)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavIsPracticeTopLink
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavIsPracticeTopLink As Nullable(Of System.Boolean)
            Get
                Return MyBase.GetSystemBoolean(NavLinkMetadata.ColumnNames.NavIsPracticeTopLink)
            End Get

            Set(ByVal value As Nullable(Of System.Boolean))
                If MyBase.SetSystemBoolean(NavLinkMetadata.ColumnNames.NavIsPracticeTopLink, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavIsPracticeTopLink)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavDefaultExpanded
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavDefaultExpanded As Nullable(Of System.Boolean)
            Get
                Return MyBase.GetSystemBoolean(NavLinkMetadata.ColumnNames.NavDefaultExpanded)
            End Get

            Set(ByVal value As Nullable(Of System.Boolean))
                If MyBase.SetSystemBoolean(NavLinkMetadata.ColumnNames.NavDefaultExpanded, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavDefaultExpanded)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavSiteMapKeyWord
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavSiteMapKeyWord As System.String
            Get
                Return MyBase.GetSystemString(NavLinkMetadata.ColumnNames.NavSiteMapKeyWord)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(NavLinkMetadata.ColumnNames.NavSiteMapKeyWord, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavSiteMapKeyWord)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavAllReportsKeyword
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavAllReportsKeyword As System.String
            Get
                Return MyBase.GetSystemString(NavLinkMetadata.ColumnNames.NavAllReportsKeyword)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(NavLinkMetadata.ColumnNames.NavAllReportsKeyword, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavAllReportsKeyword)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavAllDataKeyword
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavAllDataKeyword As System.String
            Get
                Return MyBase.GetSystemString(NavLinkMetadata.ColumnNames.NavAllDataKeyword)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(NavLinkMetadata.ColumnNames.NavAllDataKeyword, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavAllDataKeyword)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavTarget
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavTarget As System.String
            Get
                Return MyBase.GetSystemString(NavLinkMetadata.ColumnNames.NavTarget)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(NavLinkMetadata.ColumnNames.NavTarget, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavTarget)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavType
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavType As System.String
            Get
                Return MyBase.GetSystemString(NavLinkMetadata.ColumnNames.NavType)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(NavLinkMetadata.ColumnNames.NavType, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavType)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavComment
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavComment As System.String
            Get
                Return MyBase.GetSystemString(NavLinkMetadata.ColumnNames.NavComment)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(NavLinkMetadata.ColumnNames.NavComment, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavComment)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavConstant
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavConstant As System.String
            Get
                Return MyBase.GetSystemString(NavLinkMetadata.ColumnNames.NavConstant)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(NavLinkMetadata.ColumnNames.NavConstant, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavConstant)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavRptCode
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavRptCode As System.String
            Get
                Return MyBase.GetSystemString(NavLinkMetadata.ColumnNames.NavRptCode)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(NavLinkMetadata.ColumnNames.NavRptCode, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavRptCode)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavGridId
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavGridId As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(NavLinkMetadata.ColumnNames.NavGridId)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(NavLinkMetadata.ColumnNames.NavGridId, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavGridId)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavChartId
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavChartId As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(NavLinkMetadata.ColumnNames.NavChartId)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(NavLinkMetadata.ColumnNames.NavChartId, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavChartId)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavExtractId
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavExtractId As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(NavLinkMetadata.ColumnNames.NavExtractId)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(NavLinkMetadata.ColumnNames.NavExtractId, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavExtractId)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavBypassFilter
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavBypassFilter As Nullable(Of System.Boolean)
            Get
                Return MyBase.GetSystemBoolean(NavLinkMetadata.ColumnNames.NavBypassFilter)
            End Get

            Set(ByVal value As Nullable(Of System.Boolean))
                If MyBase.SetSystemBoolean(NavLinkMetadata.ColumnNames.NavBypassFilter, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavBypassFilter)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.NavStatusToolTip
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property NavStatusToolTip As System.String
            Get
                Return MyBase.GetSystemString(NavLinkMetadata.ColumnNames.NavStatusToolTip)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(NavLinkMetadata.ColumnNames.NavStatusToolTip, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.NavStatusToolTip)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.TimeStamp
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property TimeStamp As System.Byte()
            Get
                Return MyBase.GetSystemByteArray(NavLinkMetadata.ColumnNames.TimeStamp)
            End Get

            Set(ByVal value As System.Byte())
                If MyBase.SetSystemByteArray(NavLinkMetadata.ColumnNames.TimeStamp, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.TimeStamp)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.slideMenuId
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property SlideMenuId As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(NavLinkMetadata.ColumnNames.SlideMenuId)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(NavLinkMetadata.ColumnNames.SlideMenuId, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.SlideMenuId)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.slideGroupId
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property SlideGroupId As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(NavLinkMetadata.ColumnNames.SlideGroupId)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(NavLinkMetadata.ColumnNames.SlideGroupId, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.SlideGroupId)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.slideLevelId
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property SlideLevelId As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(NavLinkMetadata.ColumnNames.SlideLevelId)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(NavLinkMetadata.ColumnNames.SlideLevelId, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.SlideLevelId)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.slideType
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property SlideType As System.String
            Get
                Return MyBase.GetSystemString(NavLinkMetadata.ColumnNames.SlideType)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(NavLinkMetadata.ColumnNames.SlideType, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.SlideType)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.slideParentId
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property SlideParentId As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(NavLinkMetadata.ColumnNames.SlideParentId)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(NavLinkMetadata.ColumnNames.SlideParentId, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.SlideParentId)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.slideOrder
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property SlideOrder As Nullable(Of System.Int32)
            Get
                Return MyBase.GetSystemInt32(NavLinkMetadata.ColumnNames.SlideOrder)
            End Get

            Set(ByVal value As Nullable(Of System.Int32))
                If MyBase.SetSystemInt32(NavLinkMetadata.ColumnNames.SlideOrder, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.SlideOrder)
                End If
            End Set
        End Property

        ' <summary>
        ' Maps to NavLink.slideImageClassName
        ' </summary>
        <DataMember(EmitDefaultValue:=False)> _
        Public Overridable Property SlideImageClassName As System.String
            Get
                Return MyBase.GetSystemString(NavLinkMetadata.ColumnNames.SlideImageClassName)
            End Get

            Set(ByVal value As System.String)
                If MyBase.SetSystemString(NavLinkMetadata.ColumnNames.SlideImageClassName, value) Then
                    OnPropertyChanged(NavLinkMetadata.PropertyNames.SlideImageClassName)
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

                        Case "NavControlId"
                            Me.str().NavControlId = CType(value, String)

                        Case "NavPracticeID"
                            Me.str().NavPracticeID = CType(value, String)

                        Case "NavLevelId"
                            Me.str().NavLevelId = CType(value, String)

                        Case "NavParentLinkId"
                            Me.str().NavParentLinkId = CType(value, String)

                        Case "NavLinkId"
                            Me.str().NavLinkId = CType(value, String)

                        Case "NavText"
                            Me.str().NavText = CType(value, String)

                        Case "NavUrl"
                            Me.str().NavUrl = CType(value, String)

                        Case "NavOrder"
                            Me.str().NavOrder = CType(value, String)

                        Case "NavToolTip"
                            Me.str().NavToolTip = CType(value, String)

                        Case "NavVisible"
                            Me.str().NavVisible = CType(value, String)

                        Case "NavEnabled"
                            Me.str().NavEnabled = CType(value, String)

                        Case "NavSpcFeature"
                            Me.str().NavSpcFeature = CType(value, String)

                        Case "NavIsPracticeTopLink"
                            Me.str().NavIsPracticeTopLink = CType(value, String)

                        Case "NavDefaultExpanded"
                            Me.str().NavDefaultExpanded = CType(value, String)

                        Case "NavSiteMapKeyWord"
                            Me.str().NavSiteMapKeyWord = CType(value, String)

                        Case "NavAllReportsKeyword"
                            Me.str().NavAllReportsKeyword = CType(value, String)

                        Case "NavAllDataKeyword"
                            Me.str().NavAllDataKeyword = CType(value, String)

                        Case "NavTarget"
                            Me.str().NavTarget = CType(value, String)

                        Case "NavType"
                            Me.str().NavType = CType(value, String)

                        Case "NavComment"
                            Me.str().NavComment = CType(value, String)

                        Case "NavConstant"
                            Me.str().NavConstant = CType(value, String)

                        Case "NavRptCode"
                            Me.str().NavRptCode = CType(value, String)

                        Case "NavGridId"
                            Me.str().NavGridId = CType(value, String)

                        Case "NavChartId"
                            Me.str().NavChartId = CType(value, String)

                        Case "NavExtractId"
                            Me.str().NavExtractId = CType(value, String)

                        Case "NavBypassFilter"
                            Me.str().NavBypassFilter = CType(value, String)

                        Case "NavStatusToolTip"
                            Me.str().NavStatusToolTip = CType(value, String)

                        Case "SlideMenuId"
                            Me.str().SlideMenuId = CType(value, String)

                        Case "SlideGroupId"
                            Me.str().SlideGroupId = CType(value, String)

                        Case "SlideLevelId"
                            Me.str().SlideLevelId = CType(value, String)

                        Case "SlideType"
                            Me.str().SlideType = CType(value, String)

                        Case "SlideParentId"
                            Me.str().SlideParentId = CType(value, String)

                        Case "SlideOrder"
                            Me.str().SlideOrder = CType(value, String)

                        Case "SlideImageClassName"
                            Me.str().SlideImageClassName = CType(value, String)

                    End Select

                Else

                    Select Case name

                        Case "NavControlId"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.NavControlId = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(NavLinkMetadata.PropertyNames.NavControlId)
                            End If

                        Case "NavPracticeID"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.NavPracticeID = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(NavLinkMetadata.PropertyNames.NavPracticeID)
                            End If

                        Case "NavLevelId"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.NavLevelId = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(NavLinkMetadata.PropertyNames.NavLevelId)
                            End If

                        Case "NavParentLinkId"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.NavParentLinkId = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(NavLinkMetadata.PropertyNames.NavParentLinkId)
                            End If

                        Case "NavLinkId"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.NavLinkId = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(NavLinkMetadata.PropertyNames.NavLinkId)
                            End If

                        Case "NavOrder"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.NavOrder = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(NavLinkMetadata.PropertyNames.NavOrder)
                            End If

                        Case "NavVisible"

                            If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
                                Me.NavVisible = CType(value, Nullable(Of System.Boolean))
                                OnPropertyChanged(NavLinkMetadata.PropertyNames.NavVisible)
                            End If

                        Case "NavEnabled"

                            If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
                                Me.NavEnabled = CType(value, Nullable(Of System.Boolean))
                                OnPropertyChanged(NavLinkMetadata.PropertyNames.NavEnabled)
                            End If

                        Case "NavIsPracticeTopLink"

                            If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
                                Me.NavIsPracticeTopLink = CType(value, Nullable(Of System.Boolean))
                                OnPropertyChanged(NavLinkMetadata.PropertyNames.NavIsPracticeTopLink)
                            End If

                        Case "NavDefaultExpanded"

                            If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
                                Me.NavDefaultExpanded = CType(value, Nullable(Of System.Boolean))
                                OnPropertyChanged(NavLinkMetadata.PropertyNames.NavDefaultExpanded)
                            End If

                        Case "NavGridId"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.NavGridId = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(NavLinkMetadata.PropertyNames.NavGridId)
                            End If

                        Case "NavChartId"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.NavChartId = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(NavLinkMetadata.PropertyNames.NavChartId)
                            End If

                        Case "NavExtractId"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.NavExtractId = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(NavLinkMetadata.PropertyNames.NavExtractId)
                            End If

                        Case "NavBypassFilter"

                            If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
                                Me.NavBypassFilter = CType(value, Nullable(Of System.Boolean))
                                OnPropertyChanged(NavLinkMetadata.PropertyNames.NavBypassFilter)
                            End If

                        Case "TimeStamp"

                            If value Is Nothing Or value.GetType().ToString() = "System.Byte()" Then
                                Me.TimeStamp = CType(value, System.Byte())
                                OnPropertyChanged(NavLinkMetadata.PropertyNames.TimeStamp)
                            End If

                        Case "SlideMenuId"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.SlideMenuId = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(NavLinkMetadata.PropertyNames.SlideMenuId)
                            End If

                        Case "SlideGroupId"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.SlideGroupId = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(NavLinkMetadata.PropertyNames.SlideGroupId)
                            End If

                        Case "SlideLevelId"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.SlideLevelId = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(NavLinkMetadata.PropertyNames.SlideLevelId)
                            End If

                        Case "SlideParentId"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.SlideParentId = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(NavLinkMetadata.PropertyNames.SlideParentId)
                            End If

                        Case "SlideOrder"

                            If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
                                Me.SlideOrder = CType(value, Nullable(Of System.Int32))
                                OnPropertyChanged(NavLinkMetadata.PropertyNames.SlideOrder)
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

            Public Sub New(ByVal entity As esNavLink)
                Me.entity = entity
            End Sub


            Public Property NavControlId As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.NavControlId

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavControlId = Nothing
                    Else
                        entity.NavControlId = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property NavPracticeID As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.NavPracticeID

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavPracticeID = Nothing
                    Else
                        entity.NavPracticeID = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property NavLevelId As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.NavLevelId

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavLevelId = Nothing
                    Else
                        entity.NavLevelId = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property NavParentLinkId As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.NavParentLinkId

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavParentLinkId = Nothing
                    Else
                        entity.NavParentLinkId = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property NavLinkId As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.NavLinkId

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavLinkId = Nothing
                    Else
                        entity.NavLinkId = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property NavText As System.String
                Get
                    Dim data_ As System.String = entity.NavText

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavText = Nothing
                    Else
                        entity.NavText = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property NavUrl As System.String
                Get
                    Dim data_ As System.String = entity.NavUrl

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavUrl = Nothing
                    Else
                        entity.NavUrl = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property NavOrder As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.NavOrder

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavOrder = Nothing
                    Else
                        entity.NavOrder = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property NavToolTip As System.String
                Get
                    Dim data_ As System.String = entity.NavToolTip

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavToolTip = Nothing
                    Else
                        entity.NavToolTip = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property NavVisible As System.String
                Get
                    Dim data_ As Nullable(Of System.Boolean) = entity.NavVisible

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavVisible = Nothing
                    Else
                        entity.NavVisible = Convert.ToBoolean(Value)
                    End If
                End Set
            End Property

            Public Property NavEnabled As System.String
                Get
                    Dim data_ As Nullable(Of System.Boolean) = entity.NavEnabled

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavEnabled = Nothing
                    Else
                        entity.NavEnabled = Convert.ToBoolean(Value)
                    End If
                End Set
            End Property

            Public Property NavSpcFeature As System.String
                Get
                    Dim data_ As System.String = entity.NavSpcFeature

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavSpcFeature = Nothing
                    Else
                        entity.NavSpcFeature = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property NavIsPracticeTopLink As System.String
                Get
                    Dim data_ As Nullable(Of System.Boolean) = entity.NavIsPracticeTopLink

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavIsPracticeTopLink = Nothing
                    Else
                        entity.NavIsPracticeTopLink = Convert.ToBoolean(Value)
                    End If
                End Set
            End Property

            Public Property NavDefaultExpanded As System.String
                Get
                    Dim data_ As Nullable(Of System.Boolean) = entity.NavDefaultExpanded

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavDefaultExpanded = Nothing
                    Else
                        entity.NavDefaultExpanded = Convert.ToBoolean(Value)
                    End If
                End Set
            End Property

            Public Property NavSiteMapKeyWord As System.String
                Get
                    Dim data_ As System.String = entity.NavSiteMapKeyWord

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavSiteMapKeyWord = Nothing
                    Else
                        entity.NavSiteMapKeyWord = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property NavAllReportsKeyword As System.String
                Get
                    Dim data_ As System.String = entity.NavAllReportsKeyword

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavAllReportsKeyword = Nothing
                    Else
                        entity.NavAllReportsKeyword = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property NavAllDataKeyword As System.String
                Get
                    Dim data_ As System.String = entity.NavAllDataKeyword

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavAllDataKeyword = Nothing
                    Else
                        entity.NavAllDataKeyword = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property NavTarget As System.String
                Get
                    Dim data_ As System.String = entity.NavTarget

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavTarget = Nothing
                    Else
                        entity.NavTarget = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property NavType As System.String
                Get
                    Dim data_ As System.String = entity.NavType

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavType = Nothing
                    Else
                        entity.NavType = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property NavComment As System.String
                Get
                    Dim data_ As System.String = entity.NavComment

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavComment = Nothing
                    Else
                        entity.NavComment = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property NavConstant As System.String
                Get
                    Dim data_ As System.String = entity.NavConstant

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavConstant = Nothing
                    Else
                        entity.NavConstant = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property NavRptCode As System.String
                Get
                    Dim data_ As System.String = entity.NavRptCode

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavRptCode = Nothing
                    Else
                        entity.NavRptCode = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property NavGridId As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.NavGridId

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavGridId = Nothing
                    Else
                        entity.NavGridId = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property NavChartId As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.NavChartId

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavChartId = Nothing
                    Else
                        entity.NavChartId = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property NavExtractId As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.NavExtractId

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavExtractId = Nothing
                    Else
                        entity.NavExtractId = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property NavBypassFilter As System.String
                Get
                    Dim data_ As Nullable(Of System.Boolean) = entity.NavBypassFilter

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavBypassFilter = Nothing
                    Else
                        entity.NavBypassFilter = Convert.ToBoolean(Value)
                    End If
                End Set
            End Property

            Public Property NavStatusToolTip As System.String
                Get
                    Dim data_ As System.String = entity.NavStatusToolTip

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.NavStatusToolTip = Nothing
                    Else
                        entity.NavStatusToolTip = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property SlideMenuId As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.SlideMenuId

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.SlideMenuId = Nothing
                    Else
                        entity.SlideMenuId = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property SlideGroupId As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.SlideGroupId

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.SlideGroupId = Nothing
                    Else
                        entity.SlideGroupId = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property SlideLevelId As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.SlideLevelId

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.SlideLevelId = Nothing
                    Else
                        entity.SlideLevelId = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property SlideType As System.String
                Get
                    Dim data_ As System.String = entity.SlideType

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.SlideType = Nothing
                    Else
                        entity.SlideType = Convert.ToString(Value)
                    End If
                End Set
            End Property

            Public Property SlideParentId As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.SlideParentId

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.SlideParentId = Nothing
                    Else
                        entity.SlideParentId = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property SlideOrder As System.String
                Get
                    Dim data_ As Nullable(Of System.Int32) = entity.SlideOrder

                    If Not data_.HasValue Then

                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.SlideOrder = Nothing
                    Else
                        entity.SlideOrder = Convert.ToInt32(Value)
                    End If
                End Set
            End Property

            Public Property SlideImageClassName As System.String
                Get
                    Dim data_ As System.String = entity.SlideImageClassName

                    If data_ Is Nothing Then
                        Return String.Empty
                    Else
                        Return Convert.ToString(data_)
                    End If
                End Get

                Set(ByVal Value As System.String)
                    If String.IsNullOrEmpty(value) Then
                        entity.SlideImageClassName = Nothing
                    Else
                        entity.SlideImageClassName = Convert.ToString(Value)
                    End If
                End Set
            End Property


            Private entity As esNavLink
        End Class


        <NonSerialized> _
        <IgnoreDataMember> _
              Private _esstrings As esStrings

#End Region

#Region "Housekeeping methods"

        Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
            Get
                Return NavLinkMetadata.Meta()
            End Get
        End Property

#End Region

#Region "Query Logic"

        Public ReadOnly Property Query() As NavLinkQuery
            Get
                If Me.m_query Is Nothing Then
                    Me.m_query = New NavLinkQuery()
                    InitQuery(Me.m_query)
                End If

                Return Me.m_query
            End Get
        End Property

        Public Overloads Function Load(ByVal query As NavLinkQuery) As Boolean
            Me.m_query = query
            InitQuery(Me.m_query)
            Return Me.Query.Load()
        End Function

        Protected Sub InitQuery(ByVal query As NavLinkQuery)
            query.OnLoadDelegate = AddressOf OnQueryLoaded

            If Not query.es2.HasConnection Then
                query.es2.Connection = DirectCast(Me, IEntity).Connection
            End If
        End Sub

#End Region

        <IgnoreDataMember> _
        Private m_query As NavLinkQuery

    End Class



    <Serializable()> _
    Partial Public MustInherit Class esNavLinkCollection
        Inherits esEntityCollection(Of NavLink)

#Region "Housekeeping methods"
        Protected Overloads Overrides ReadOnly Property Meta() As IMetadata
            Get
                Return NavLinkMetadata.Meta()
            End Get
        End Property

        Protected Overloads Overrides Function GetCollectionName() As String
            Return "NavLinkCollection"
        End Function

#End Region

#Region "Query Logic"


        <BrowsableAttribute(False)> _
        Public ReadOnly Property Query() As NavLinkQuery
            Get
                If Me.m_query Is Nothing Then
                    Me.m_query = New NavLinkQuery()
                    InitQuery(Me.m_query)
                End If

                Return Me.m_query
            End Get
        End Property

        Public Overloads Function Load(ByVal query As NavLinkQuery) As Boolean
            Me.m_query = query
            InitQuery(Me.m_query)
            Return Query.Load()
        End Function

        Protected Overloads Overrides Function GetDynamicQuery() As esDynamicQuery
            If Me.m_query Is Nothing Then
                Me.m_query = New NavLinkQuery()
                Me.InitQuery(m_query)
            End If
            Return Me.m_query
        End Function

        Protected Sub InitQuery(ByVal query As NavLinkQuery)
            query.OnLoadDelegate = AddressOf OnQueryLoaded

            If Not query.es2.HasConnection Then
                query.es2.Connection = DirectCast(Me, IEntityCollection).Connection
            End If
        End Sub

        Protected Overloads Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
            Me.InitQuery(DirectCast(query, NavLinkQuery))
        End Sub

#End Region

        Private m_query As NavLinkQuery
    End Class



    <Serializable> _
    Partial Public MustInherit Class esNavLinkQuery
        Inherits esDynamicQuery

        Protected Overrides ReadOnly Property Meta() As IMetadata
            Get
                Return NavLinkMetadata.Meta()
            End Get
        End Property

#Region "QueryItemFromName"

        Protected Overrides Function QueryItemFromName(ByVal name As String) As esQueryItem
            Select Case name
                Case "NavControlId"
                    Return Me.NavControlId
                Case "NavPracticeID"
                    Return Me.NavPracticeID
                Case "NavLevelId"
                    Return Me.NavLevelId
                Case "NavParentLinkId"
                    Return Me.NavParentLinkId
                Case "NavLinkId"
                    Return Me.NavLinkId
                Case "NavText"
                    Return Me.NavText
                Case "NavUrl"
                    Return Me.NavUrl
                Case "NavOrder"
                    Return Me.NavOrder
                Case "NavToolTip"
                    Return Me.NavToolTip
                Case "NavVisible"
                    Return Me.NavVisible
                Case "NavEnabled"
                    Return Me.NavEnabled
                Case "NavSpcFeature"
                    Return Me.NavSpcFeature
                Case "NavIsPracticeTopLink"
                    Return Me.NavIsPracticeTopLink
                Case "NavDefaultExpanded"
                    Return Me.NavDefaultExpanded
                Case "NavSiteMapKeyWord"
                    Return Me.NavSiteMapKeyWord
                Case "NavAllReportsKeyword"
                    Return Me.NavAllReportsKeyword
                Case "NavAllDataKeyword"
                    Return Me.NavAllDataKeyword
                Case "NavTarget"
                    Return Me.NavTarget
                Case "NavType"
                    Return Me.NavType
                Case "NavComment"
                    Return Me.NavComment
                Case "NavConstant"
                    Return Me.NavConstant
                Case "NavRptCode"
                    Return Me.NavRptCode
                Case "NavGridId"
                    Return Me.NavGridId
                Case "NavChartId"
                    Return Me.NavChartId
                Case "NavExtractId"
                    Return Me.NavExtractId
                Case "NavBypassFilter"
                    Return Me.NavBypassFilter
                Case "NavStatusToolTip"
                    Return Me.NavStatusToolTip
                Case "TimeStamp"
                    Return Me.TimeStamp
                Case "SlideMenuId"
                    Return Me.SlideMenuId
                Case "SlideGroupId"
                    Return Me.SlideGroupId
                Case "SlideLevelId"
                    Return Me.SlideLevelId
                Case "SlideType"
                    Return Me.SlideType
                Case "SlideParentId"
                    Return Me.SlideParentId
                Case "SlideOrder"
                    Return Me.SlideOrder
                Case "SlideImageClassName"
                    Return Me.SlideImageClassName
                Case Else
                    Return Nothing
            End Select
        End Function

#End Region

#Region "esQueryItems"


        Public ReadOnly Property NavControlId As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavControlId, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property NavPracticeID As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavPracticeID, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property NavLevelId As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavLevelId, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property NavParentLinkId As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavParentLinkId, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property NavLinkId As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavLinkId, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property NavText As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavText, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property NavUrl As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavUrl, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property NavOrder As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavOrder, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property NavToolTip As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavToolTip, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property NavVisible As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavVisible, esSystemType.Boolean)
            End Get
        End Property

        Public ReadOnly Property NavEnabled As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavEnabled, esSystemType.Boolean)
            End Get
        End Property

        Public ReadOnly Property NavSpcFeature As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavSpcFeature, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property NavIsPracticeTopLink As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavIsPracticeTopLink, esSystemType.Boolean)
            End Get
        End Property

        Public ReadOnly Property NavDefaultExpanded As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavDefaultExpanded, esSystemType.Boolean)
            End Get
        End Property

        Public ReadOnly Property NavSiteMapKeyWord As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavSiteMapKeyWord, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property NavAllReportsKeyword As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavAllReportsKeyword, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property NavAllDataKeyword As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavAllDataKeyword, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property NavTarget As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavTarget, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property NavType As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavType, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property NavComment As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavComment, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property NavConstant As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavConstant, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property NavRptCode As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavRptCode, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property NavGridId As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavGridId, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property NavChartId As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavChartId, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property NavExtractId As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavExtractId, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property NavBypassFilter As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavBypassFilter, esSystemType.Boolean)
            End Get
        End Property

        Public ReadOnly Property NavStatusToolTip As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.NavStatusToolTip, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property TimeStamp As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.TimeStamp, esSystemType.ByteArray)
            End Get
        End Property

        Public ReadOnly Property SlideMenuId As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.SlideMenuId, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property SlideGroupId As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.SlideGroupId, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property SlideLevelId As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.SlideLevelId, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property SlideType As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.SlideType, esSystemType.String)
            End Get
        End Property

        Public ReadOnly Property SlideParentId As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.SlideParentId, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property SlideOrder As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.SlideOrder, esSystemType.Int32)
            End Get
        End Property

        Public ReadOnly Property SlideImageClassName As esQueryItem
            Get
                Return New esQueryItem(Me, NavLinkMetadata.ColumnNames.SlideImageClassName, esSystemType.String)
            End Get
        End Property

#End Region

    End Class



    <Serializable> _
    Partial Public Class NavLinkMetadata
        Inherits esMetadata
        Implements IMetadata

#Region "Protected Constructor"
        Protected Sub New()
            m_columns = New esColumnMetadataCollection()
            Dim c As esColumnMetadata

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavControlId, 0, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavControlId
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavPracticeID, 1, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavPracticeID
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavLevelId, 2, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavLevelId
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavParentLinkId, 3, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavParentLinkId
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavLinkId, 4, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavLinkId
            c.IsInPrimaryKey = True
            c.IsAutoIncrement = True
            c.NumericPrecision = 10
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavText, 5, GetType(System.String), esSystemType.String)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavText
            c.CharacterMaxLength = 50
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavUrl, 6, GetType(System.String), esSystemType.String)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavUrl
            c.CharacterMaxLength = 255
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavOrder, 7, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavOrder
            c.NumericPrecision = 10
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavToolTip, 8, GetType(System.String), esSystemType.String)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavToolTip
            c.CharacterMaxLength = 50
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavVisible, 9, GetType(System.Boolean), esSystemType.Boolean)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavVisible
            c.HasDefault = True
            c.Default = "((-1))"
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavEnabled, 10, GetType(System.Boolean), esSystemType.Boolean)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavEnabled
            c.HasDefault = True
            c.Default = "((-1))"
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavSpcFeature, 11, GetType(System.String), esSystemType.String)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavSpcFeature
            c.CharacterMaxLength = 50
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavIsPracticeTopLink, 12, GetType(System.Boolean), esSystemType.Boolean)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavIsPracticeTopLink
            c.HasDefault = True
            c.Default = "((0))"
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavDefaultExpanded, 13, GetType(System.Boolean), esSystemType.Boolean)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavDefaultExpanded
            c.HasDefault = True
            c.Default = "((0))"
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavSiteMapKeyWord, 14, GetType(System.String), esSystemType.String)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavSiteMapKeyWord
            c.CharacterMaxLength = 50
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavAllReportsKeyword, 15, GetType(System.String), esSystemType.String)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavAllReportsKeyword
            c.CharacterMaxLength = 50
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavAllDataKeyword, 16, GetType(System.String), esSystemType.String)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavAllDataKeyword
            c.CharacterMaxLength = 50
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavTarget, 17, GetType(System.String), esSystemType.String)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavTarget
            c.CharacterMaxLength = 25
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavType, 18, GetType(System.String), esSystemType.String)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavType
            c.CharacterMaxLength = 50
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavComment, 19, GetType(System.String), esSystemType.String)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavComment
            c.CharacterMaxLength = 75
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavConstant, 20, GetType(System.String), esSystemType.String)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavConstant
            c.CharacterMaxLength = 50
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavRptCode, 21, GetType(System.String), esSystemType.String)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavRptCode
            c.CharacterMaxLength = 50
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavGridId, 22, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavGridId
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavChartId, 23, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavChartId
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavExtractId, 24, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavExtractId
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavBypassFilter, 25, GetType(System.Boolean), esSystemType.Boolean)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavBypassFilter
            c.HasDefault = True
            c.Default = "((0))"
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.NavStatusToolTip, 26, GetType(System.String), esSystemType.String)
            c.PropertyName = NavLinkMetadata.PropertyNames.NavStatusToolTip
            c.CharacterMaxLength = 200
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.TimeStamp, 27, GetType(System.Byte()), esSystemType.ByteArray)
            c.PropertyName = NavLinkMetadata.PropertyNames.TimeStamp
            c.CharacterMaxLength = 8
            c.IsNullable = True
            c.IsComputed = True
            c.IsConcurrency = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.SlideMenuId, 28, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = NavLinkMetadata.PropertyNames.SlideMenuId
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.SlideGroupId, 29, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = NavLinkMetadata.PropertyNames.SlideGroupId
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.SlideLevelId, 30, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = NavLinkMetadata.PropertyNames.SlideLevelId
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.SlideType, 31, GetType(System.String), esSystemType.String)
            c.PropertyName = NavLinkMetadata.PropertyNames.SlideType
            c.CharacterMaxLength = 25
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.SlideParentId, 32, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = NavLinkMetadata.PropertyNames.SlideParentId
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.SlideOrder, 33, GetType(System.Int32), esSystemType.Int32)
            c.PropertyName = NavLinkMetadata.PropertyNames.SlideOrder
            c.NumericPrecision = 10
            c.IsNullable = True
            m_columns.Add(c)

            c = New esColumnMetadata(NavLinkMetadata.ColumnNames.SlideImageClassName, 34, GetType(System.String), esSystemType.String)
            c.PropertyName = NavLinkMetadata.PropertyNames.SlideImageClassName
            c.CharacterMaxLength = 25
            c.IsNullable = True
            m_columns.Add(c)

        End Sub
#End Region

        Public Shared Function Meta() As NavLinkMetadata
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
            Public Const NavControlId As String = "NavControlId"
            Public Const NavPracticeID As String = "NavPracticeID"
            Public Const NavLevelId As String = "NavLevelId"
            Public Const NavParentLinkId As String = "NavParentLinkId"
            Public Const NavLinkId As String = "NavLinkId"
            Public Const NavText As String = "NavText"
            Public Const NavUrl As String = "NavUrl"
            Public Const NavOrder As String = "NavOrder"
            Public Const NavToolTip As String = "NavToolTip"
            Public Const NavVisible As String = "NavVisible"
            Public Const NavEnabled As String = "NavEnabled"
            Public Const NavSpcFeature As String = "NavSpcFeature"
            Public Const NavIsPracticeTopLink As String = "NavIsPracticeTopLink"
            Public Const NavDefaultExpanded As String = "NavDefaultExpanded"
            Public Const NavSiteMapKeyWord As String = "NavSiteMapKeyWord"
            Public Const NavAllReportsKeyword As String = "NavAllReportsKeyword"
            Public Const NavAllDataKeyword As String = "NavAllDataKeyword"
            Public Const NavTarget As String = "NavTarget"
            Public Const NavType As String = "NavType"
            Public Const NavComment As String = "NavComment"
            Public Const NavConstant As String = "NavConstant"
            Public Const NavRptCode As String = "NavRptCode"
            Public Const NavGridId As String = "NavGridId"
            Public Const NavChartId As String = "NavChartId"
            Public Const NavExtractId As String = "NavExtractId"
            Public Const NavBypassFilter As String = "NavBypassFilter"
            Public Const NavStatusToolTip As String = "NavStatusToolTip"
            Public Const TimeStamp As String = "TimeStamp"
            Public Const SlideMenuId As String = "slideMenuId"
            Public Const SlideGroupId As String = "slideGroupId"
            Public Const SlideLevelId As String = "slideLevelId"
            Public Const SlideType As String = "slideType"
            Public Const SlideParentId As String = "slideParentId"
            Public Const SlideOrder As String = "slideOrder"
            Public Const SlideImageClassName As String = "slideImageClassName"
        End Class
#End Region

#Region "PropertyNames"
        Public Class PropertyNames
            Public Const NavControlId As String = "NavControlId"
            Public Const NavPracticeID As String = "NavPracticeID"
            Public Const NavLevelId As String = "NavLevelId"
            Public Const NavParentLinkId As String = "NavParentLinkId"
            Public Const NavLinkId As String = "NavLinkId"
            Public Const NavText As String = "NavText"
            Public Const NavUrl As String = "NavUrl"
            Public Const NavOrder As String = "NavOrder"
            Public Const NavToolTip As String = "NavToolTip"
            Public Const NavVisible As String = "NavVisible"
            Public Const NavEnabled As String = "NavEnabled"
            Public Const NavSpcFeature As String = "NavSpcFeature"
            Public Const NavIsPracticeTopLink As String = "NavIsPracticeTopLink"
            Public Const NavDefaultExpanded As String = "NavDefaultExpanded"
            Public Const NavSiteMapKeyWord As String = "NavSiteMapKeyWord"
            Public Const NavAllReportsKeyword As String = "NavAllReportsKeyword"
            Public Const NavAllDataKeyword As String = "NavAllDataKeyword"
            Public Const NavTarget As String = "NavTarget"
            Public Const NavType As String = "NavType"
            Public Const NavComment As String = "NavComment"
            Public Const NavConstant As String = "NavConstant"
            Public Const NavRptCode As String = "NavRptCode"
            Public Const NavGridId As String = "NavGridId"
            Public Const NavChartId As String = "NavChartId"
            Public Const NavExtractId As String = "NavExtractId"
            Public Const NavBypassFilter As String = "NavBypassFilter"
            Public Const NavStatusToolTip As String = "NavStatusToolTip"
            Public Const TimeStamp As String = "TimeStamp"
            Public Const SlideMenuId As String = "SlideMenuId"
            Public Const SlideGroupId As String = "SlideGroupId"
            Public Const SlideLevelId As String = "SlideLevelId"
            Public Const SlideType As String = "SlideType"
            Public Const SlideParentId As String = "SlideParentId"
            Public Const SlideOrder As String = "SlideOrder"
            Public Const SlideImageClassName As String = "SlideImageClassName"
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
            SyncLock GetType(NavLinkMetadata)

                If NavLinkMetadata.mapDelegates Is Nothing Then
                    NavLinkMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
                End If

                If NavLinkMetadata._meta Is Nothing Then
                    NavLinkMetadata._meta = New NavLinkMetadata()
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



                meta.AddTypeMap("NavControlId", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("NavPracticeID", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("NavLevelId", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("NavParentLinkId", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("NavLinkId", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("NavText", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("NavUrl", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("NavOrder", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("NavToolTip", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("NavVisible", New esTypeMap("bit", "System.Boolean"))
                meta.AddTypeMap("NavEnabled", New esTypeMap("bit", "System.Boolean"))
                meta.AddTypeMap("NavSpcFeature", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("NavIsPracticeTopLink", New esTypeMap("bit", "System.Boolean"))
                meta.AddTypeMap("NavDefaultExpanded", New esTypeMap("bit", "System.Boolean"))
                meta.AddTypeMap("NavSiteMapKeyWord", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("NavAllReportsKeyword", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("NavAllDataKeyword", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("NavTarget", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("NavType", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("NavComment", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("NavConstant", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("NavRptCode", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("NavGridId", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("NavChartId", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("NavExtractId", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("NavBypassFilter", New esTypeMap("bit", "System.Boolean"))
                meta.AddTypeMap("NavStatusToolTip", New esTypeMap("nvarchar", "System.String"))
                meta.AddTypeMap("TimeStamp", New esTypeMap("timestamp", "System.Byte()"))
                meta.AddTypeMap("SlideMenuId", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("SlideGroupId", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("SlideLevelId", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("SlideType", New esTypeMap("varchar", "System.String"))
                meta.AddTypeMap("SlideParentId", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("SlideOrder", New esTypeMap("int", "System.Int32"))
                meta.AddTypeMap("SlideImageClassName", New esTypeMap("varchar", "System.String"))



                meta.Source = "NavLink"
                meta.Destination = "NavLink"

                meta.spInsert = "proc_NavLinkInsert"
                meta.spUpdate = "proc_NavLinkUpdate"
                meta.spDelete = "proc_NavLinkDelete"
                meta.spLoadAll = "proc_NavLinkLoadAll"
                meta.spLoadByPrimaryKey = "proc_NavLinkLoadByPrimaryKey"

                Me.m_providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me.m_providerMetadataMaps("esDefault")

        End Function

#End Region

        Private Shared _meta As NavLinkMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
        Private Shared _esDefault As Integer = RegisterDelegateesDefault()

    End Class

End Namespace
