Imports System.ComponentModel
Imports System.Drawing

Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Public Class BaseReport
    Inherits Telerik.Reporting.Report

    'Protected _GUID As String = ""
    'Protected _Filter As String = ""
    'Protected _Sort As String = ""
    'Protected _CurrentReport As Core.UtilReporting.Reports
    'Protected _SetId As Integer = 0
    'Protected _IsBatchReport As Boolean = False
    'Protected _RunningFromEngine As Boolean = False
    'Protected _DisplayFilter As Boolean = False
    'Protected _RptEngine As New Core.UtilReportEngine
    'Protected _ClientName As String = ""
    'Protected _RptLanguage As Core.UtilTranslation.Language = Core.UtilTranslation.Language.English

    ''Constructor For Application
    'Public Sub New(ByVal pGuid As String, Optional ByVal pRptCode As Core.UtilReporting.Reports = Nothing)
    '    InitializeComponent()
    '    _GUID = pGuid
    '    _CurrentReport = pRptCode
    '    _RptEngine = Nothing
    '    _ClientName = Core.UtilGSafe.GetValue(_GUID, "clientName")
    '    _RunningFromEngine = False
    'End Sub

    ''Constructor For Engine
    'Public Sub New(ByVal pJobId As Integer)
    '    InitializeComponent()
    '    _RptEngine.LoadJob(pJobId)
    '    _GUID = Core.UtilGSafe.GetGUID(_RptEngine.SafeId)
    '    _CurrentReport = _RptEngine.RptCode
    '    _ClientName = _RptEngine.ClientName
    '    _RunningFromEngine = True
    '    If _RptEngine.FilterValue(Core.UtilReporting.ReportFilter.Language) <> 0 Then _RptLanguage = _RptEngine.FilterValue(Core.UtilReporting.ReportFilter.Language)
    'End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    'Public ReadOnly Property DisplayFilter As Boolean
    '    Get
    '        'If _RunningFromEngine Then
    '        '     If _IsBatchReport Then
    '        '          Return True
    '        '     Else
    '        '          Return Meta.DisplayFilter
    '        '     End If
    '        'Else
    '        '     Return True
    '        'End If

    '        If Filter = "" Then
    '            Return False
    '        Else
    '            Return True
    '        End If

    '    End Get
    'End Property

    ''Public ReadOnly Property ReportEngine As Core.UtilReportEngine
    ''     Get
    ''          If _RptEngine Is Nothing Then
    ''               Return Nothing
    ''          Else
    ''               Return _RptEngine
    ''          End If
    ''     End Get
    ''End Property

    'Public ReadOnly Property FilePrefix As String
    '    Get
    '        If _RunningFromEngine Then
    '            Return _RptEngine.FilePrefix
    '        Else
    '            Return Core.UtilGSafe.GetValue(Guid, "FilePrefix")
    '        End If
    '    End Get
    'End Property

    'Public ReadOnly Property Meta As ReportMeta
    '    Get
    '        If Me.CurrentReport <> 0 Then
    '            Return ReportMeta.FindMetaByReport(Me.CurrentReport)
    '        Else
    '            Return ReportMeta.FindMetaByType(Me.GetType)
    '        End If
    '    End Get
    'End Property

    'Public ReadOnly Property Guid As String
    '    Get
    '        Return _GUID
    '    End Get
    'End Property

    'Public ReadOnly Property CurrentReport As Core.UtilReporting.Reports
    '    Get
    '        Return _CurrentReport
    '    End Get
    'End Property

    'Public Property Filter As String
    '    Get
    '        If Me.DataSource Is Nothing Then Return ""
    '        If TypeOf Me.DataSource Is DataTable Then
    '            If Me.DataSource.ExtendedProperties("Filter") IsNot Nothing Then
    '                Return Me.DataSource.ExtendedProperties("Filter")
    '            Else
    '                Return ""
    '            End If
    '        Else
    '            Return ""
    '        End If
    '    End Get
    '    Set(value As String)
    '        If value <> "" And Not IsNothing(Me.DataSource) Then
    '            Me.DataSource.ExtendedProperties("Filter") = value
    '        End If
    '    End Set
    'End Property

    'Public ReadOnly Property Sort As String
    '    Get
    '        If _RunningFromEngine Then
    '            Return Meta.DefaultSort
    '        Else
    '            If Me.DataSource Is Nothing Then Return ""
    '            If TypeOf Me.DataSource Is DataTable Then
    '                If Me.DataSource.ExtendedProperties("Sort") IsNot Nothing Then
    '                    Return Me.DataSource.ExtendedProperties("Sort")
    '                Else
    '                    Return ""
    '                End If
    '            Else
    '                Return ""
    '            End If
    '        End If
    '    End Get
    'End Property

    'Public Property IsBatchReport As Boolean
    '    Get
    '        Return _IsBatchReport
    '    End Get
    '    Set(value As Boolean)
    '        _IsBatchReport = value
    '    End Set
    'End Property


    'Public ReadOnly Property Practice As String
    '    Get
    '        Dim zPractice As Core.UtilPractice.PracticeEnum

    '        If _RunningFromEngine Then
    '            zPractice = Core.UtilReporting.GetReportPractice(CurrentReport)
    '        Else
    '            zPractice = Core.UtilGSafe.GetCurrentPracticeEnum(Guid)
    '        End If

    '        Return GetPracticeForReportTitle(zPractice)

    '    End Get

    'End Property

    'Private Function GetPracticeForReportTitle(ByVal pPractice As Core.UtilPractice.PracticeEnum) As String
    '    Select Case pPractice
    '        Case Core.UtilPractice.PracticeEnum.BM
    '            Return "B&M"
    '        Case Core.UtilPractice.PracticeEnum.Fire
    '            Return "Fire"
    '        Case Core.UtilPractice.PracticeEnum.Infrared
    '            Return "Infrared"
    '        Case Core.UtilPractice.PracticeEnum.Jurisdictional
    '            Return "Jurisdictional"
    '        Case Core.UtilPractice.PracticeEnum.NatHazFlood
    '            Return "Natural Hazards/Flood"
    '        Case Core.UtilPractice.PracticeEnum.NatHazSeismic
    '            Return "Natural Hazards/Seismic"
    '        Case Core.UtilPractice.PracticeEnum.NatHazWind
    '            Return "Natural Hazards/Wind"
    '        Case Else
    '            Return ""
    '    End Select
    'End Function

    'Public Sub SetStandardHeader(ByVal pHtmlTextBox As Telerik.Reporting.Processing.HtmlTextBox)
    '    If Meta.HeaderType = ReportHeaderType.Standard Then
    '        Dim zValue As String = GetStandardHeaderStyle()
    '        RaiseEvent WritingHeader(pHtmlTextBox, New ReportHeaderEventArgs(Meta.HeaderType, zValue))
    '        pHtmlTextBox.Value = zValue
    '        RaiseEvent WroteHeader(pHtmlTextBox, New ReportHeaderEventArgs(Meta.HeaderType, zValue))
    '        Me.Groups(1).GroupHeader.Visible = False

    '    End If
    'End Sub

    'Public Sub SetAlternateHeader(ByVal pHtmlTextBox As Telerik.Reporting.Processing.HtmlTextBox)
    '    If Meta.HeaderType = ReportHeaderType.Alternate Then
    '        Dim zValue As String = GetAlternateHeaderStyle()
    '        RaiseEvent WritingHeader(pHtmlTextBox, New ReportHeaderEventArgs(Meta.HeaderType, zValue))
    '        pHtmlTextBox.Value = zValue
    '        RaiseEvent WroteHeader(pHtmlTextBox, New ReportHeaderEventArgs(Meta.HeaderType, zValue))
    '        Me.Groups(1).GroupHeader.Visible = True
    '    End If
    'End Sub

    'Public Function EncodeHtml(ByVal pValue As String) As String
    '    Return System.Web.HttpUtility.HtmlEncode(pValue)
    'End Function

    'Public Sub SetFilter(ByVal pFilterHtmlTextBox As Telerik.Reporting.Processing.HtmlTextBox)

    '    If Me.DisplayFilter Then
    '        Dim zFilterString As String = "<b>Filter:&nbsp;&nbsp;</b>" & System.Web.HttpUtility.HtmlEncode(Filter)
    '        RaiseEvent WritingFilter(pFilterHtmlTextBox, New ReportEventArgs(zFilterString))
    '        pFilterHtmlTextBox.Value = zFilterString
    '        pFilterHtmlTextBox.Style.TextAlign = HorizontalAlign.Left
    '        RaiseEvent WroteFilter(pFilterHtmlTextBox, New ReportEventArgs(zFilterString))
    '    Else
    '        Groups(2).GroupHeader.Visible = False
    '    End If
    'End Sub

    'Protected Sub SetSort(ByVal pHtmlTextBox As Telerik.Reporting.Processing.HtmlTextBox)
    '    Dim zSortString As String = System.Web.HttpUtility.HtmlEncode(Sort)
    '    RaiseEvent WritingSort(pHtmlTextBox, New ReportEventArgs(zSortString))
    '    pHtmlTextBox.Value = zSortString
    '    RaiseEvent WroteSort(pHtmlTextBox, New ReportEventArgs(zSortString))
    'End Sub

    'Protected Sub SetDisclaimer(ByVal pHtmlTextBox As Telerik.Reporting.Processing.HtmlTextBox)
    '    RaiseEvent WritingDisclaimer(pHtmlTextBox, New ReportEventArgs(pHtmlTextBox.Value))
    '    pHtmlTextBox.Visible = Meta.DisplayDisclaimer
    '    RaiseEvent WroteDisclaimer(pHtmlTextBox, New ReportEventArgs(pHtmlTextBox.Value))
    'End Sub

    'Public Overloads Property DataSource
    '    Set(value)
    '        RaiseEvent AppyingDataSource(Me, New ReportDataSourceEventArgs(value))
    '        MyBase.DataSource = value

    '        If TypeOf MyBase.DataSource Is DataTable Then
    '            If DirectCast(MyBase.DataSource, DataTable).Rows.Count = 0 Then
    '                RaiseEvent NoData()
    '            End If
    '        End If

    '        RaiseEvent AppyingDataSource(Me, New ReportDataSourceEventArgs(value))
    '    End Set
    '    Get
    '        Return MyBase.DataSource
    '    End Get
    'End Property

    'Public Function GetStandardHeaderStyle() As String

    '    Dim zSb As New System.Text.StringBuilder
    '    With zSb
    '        .Append("<font style='color:#C6D1DE; font-weight:bold; font-style:italic; font-size:14pt;'>" & EncodeHtml(_ClientName) & "</font>")

    '        If Meta.MultiPractice Then
    '            .Append("<br/><font style='color:black;  font-weight:bold; font-size:12pt;'>" & EncodeHtml(Practice) & " " & EncodeHtml(Meta.ReportTitle) & "</font>")
    '        Else
    '            .Append("<br/><font style='color:black;  font-weight:bold; font-size:12pt;'>" & EncodeHtml(Meta.ReportTitle) & "</font>")
    '        End If

    '        If Meta.ReportSubTitle <> "" Then
    '            .Append("<br/><font style='color:black;  font-weight:bold; font-size:10pt;'>" & Meta.ReportSubTitle & "</font>")
    '        End If

    '        If Meta.ReportSub1Title <> "" Then
    '            .Append("<br/><font style='color:black; font-size:9pt;'>" & Meta.ReportSub1Title & "</font>")
    '        End If

    '    End With

    '    Return zSb.ToString

    'End Function

    'Public Function GetAlternateHeaderStyle() As String

    '    Dim zSb As New System.Text.StringBuilder
    '    With zSb
    '        If Meta.MultiPractice Then
    '            .Append("<font style='color:black;  font-weight:bold; font-style:italic; font-size:12pt;'>" & Practice & " " & Meta.ReportTitle & "</font>")
    '        Else
    '            .Append("<font style='color:black;  font-weight:bold; font-size:12pt;'>" & GetReplacements(Meta.ReportTitle) & "</font>")
    '        End If


    '        If Meta.ReportSubTitle <> "" Then
    '            .Append("<br/><font style='color:black;  font-weight:bold; font-size:10pt;'>" & GetReplacements(Meta.ReportSubTitle) & "</font>")
    '        End If

    '        If Meta.ReportSub1Title <> "" Then
    '            .Append("<br/><font style='color:black; font-size:9pt;'>" & Meta.ReportSub1Title & "</font>")
    '        End If

    '    End With

    '    Return zSb.ToString

    'End Function

    'Public Function GetReplacements(ByRef pValue As String) As String
    '    pValue = Replace(pValue, "{ClientName}", _ClientName)
    '    pValue = Replace(pValue, "{Practice}", EncodeHtml(Practice))
    '    Return pValue
    'End Function

    'Private Sub BaseReport_ItemDataBound(sender As Object, e As System.EventArgs) Handles Me.ItemDataBound
    '    Me.DocumentName = Meta.ReportName
    'End Sub

    '#Region "Custom Events"
    '    Public Event WritingFilter(ByVal sender As Object, ByRef e As ReportEventArgs)
    '    Public Event WroteFilter(ByVal sender As Object, ByRef e As ReportEventArgs)
    '    Public Event WritingDisclaimer(ByVal sender As Object, ByRef e As ReportEventArgs)
    '    Public Event WroteDisclaimer(ByVal sender As Object, ByRef e As ReportEventArgs)
    '    Public Event WritingHeader(ByVal sender As Object, ByRef e As ReportHeaderEventArgs)
    '    Public Event WroteHeader(ByVal sender As Object, e As ReportHeaderEventArgs)
    '    Public Event AppyingDataSource(ByVal sender As Object, ByRef e As ReportDataSourceEventArgs)
    '    Public Event AppliedDataSource(ByVal sender As Object, ByRef e As ReportDataSourceEventArgs)
    '    Public Event WritingSort(ByVal sender As Object, ByRef e As ReportEventArgs)
    '    Public Event WroteSort(ByVal sender As Object, ByRef e As ReportEventArgs)
    '    Public Event WritingFooterDateStamp(ByVal sender As Object, ByRef e As ReportEventArgs)
    '    Public Event WroteFooterDateStamp(ByVal sender As Object, ByRef e As ReportEventArgs)
    '    Public Event NoData()
    '#End Region

End Class


'Public Class ReportEventArgs
'    Inherits System.EventArgs
'    Public Sub New(ByVal pValue As String)
'        value = pValue
'    End Sub
'    Public Property value As String
'End Class

'Public Class ReportHeaderEventArgs
'    Inherits System.EventArgs
'    Public Sub New(ByVal pStyle As ReportHeaderType, ByVal pValue As String)
'        style = pStyle
'        value = pValue
'    End Sub
'    Public Property style As ReportHeaderType
'    Public Property value As String
'End Class

'Public Class ReportDataSourceEventArgs
'    Inherits System.EventArgs
'    Public Sub New(ByVal pValue As Object)
'        value = pValue
'    End Sub
'    Public Property value As Object
'End Class