Imports System
Imports System.Data
Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.DataLib.razor


Partial Class Grids_GridMasterPageLocationListings
    Inherits System.Web.UI.MasterPage

    Implements IPostBackEventHandler

#Region "Local Variables"
    '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
    'Private modGlobalFunctions As New modGlobalFunctions
    'Private modGrid As New modGrid
    'Private modGridLocationListings As New modGrid.LocationListings
    'Private modGridMasterPage As New modGridMasterPage
    'Private modGridMasterPageInit As New modGridMasterPage.Init
    'Private dv As DataView
    Public ServerSide_CurrencyIdFromPrefilter As String = ""
    Public ServerSide_BingMapKey As String = ""

    Private changeRowsRange As Boolean = False
#End Region

#Region "Header Information"
    Private Sub LoadDefaults()

    End Sub

    Private Sub LoadData()
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()

        ' LOAD THE BING MAP KEY - NOTE: REPLACE THIS WITH A DATABASE LOAD FROM APP SETTINGS
        ServerSide_BingMapKey = "dcLcFIaVh7HHr3kYxMqq~z3IOleVdt0Pv_JDxdK0X7Q~AgX3x6H0kBmnonP50fMwBHcpzgeQnf3y27XpwSahxCwjJQii-TcLAqgDAv10pa0s"

        ' THIS SUB IS FOR LOADING HEADER INFORMATION AND OTHER NEW DATA
        ' USE OBJECT NAME objGOCSafe
        'lblCompany.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.ClientName)          ' "ABC Company"
        'lblLoginName.Text = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.userFullName)      ' "Gary Kidney"  
        'lblTodaysDate.Text = FormatDateTime(Date.Today(), DateFormat.LongDate)
        'Dim CrumbMain As String = Libraries.CoreLib.UtilHTML.CreateCrumbtrailLink("Main", "../../Gauge/Default.aspx?sid=" & zGUID)
        'Dim CrumbSpacer As String = " "
        'Dim CrumbPractice As String = Libraries.CoreLib.UtilHTML.CreateCrumbtrailLink( _
        '    GRC.Connect.Libraries.CoreLib.UtilNav.GetNavText(Val(GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentPage))), _
        '     "../../" & GRC.Connect.Libraries.CoreLib.UtilPractice.GetPracticeFolderName(GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentTab)) & _
        '    "/Default.aspx?sid=" & zGUID)
        'lblCrumbTrail.Text = CrumbMain & CrumbSpacer & CrumbPractice

		' LOOK FOR FILTERS APPLIED
        'If GRC.Connect.Libraries.CoreLib.UtilPreference.IsFilterApplied(zGUID) = True Then
        '    lblPreferencesApplied.Visible = True
        'Else
        '    lblPreferencesApplied.Visible = False
        'End If

        ' SET THE ICON TEXT LINKS
        'hypMyPreferences.NavigateUrl = "~/Home_{{VER}}/Grids/FilterPreferences/FilterPreferences.aspx?sid=" & zGUID
        'hypSiteMap.NavigateUrl = "~/Home_{{VER}}/Sitemap/Default.aspx?sid=" & zGUID
        'hypAllReports.NavigateUrl = "~/Home_{{VER}}/Reports/Default.aspx?sid=" & zGUID
        'hypAllData.NavigateUrl = "~/Home_{{VER}}/Exports/Default.aspx?sid=" & zGUID

        '' CREATE EVENTS FOR ICON CLICKS
        'icoMyPreferences.Attributes("onclick") = Me.Page.ClientScript.GetPostBackEventReference(Me, "icoMyPreferences_Click")
        'icoSiteMap.Attributes("onclick") = Me.Page.ClientScript.GetPostBackEventReference(Me, "icoSiteMap_Click")
        'icoAllReports.Attributes("onclick") = Me.Page.ClientScript.GetPostBackEventReference(Me, "icoAllReports_Click")
        'icoAllData.Attributes("onclick") = Me.Page.ClientScript.GetPostBackEventReference(Me, "icoAllData_Click")

        ' GET THE TITLE AND SUBTITLE
        Dim zGridId = CInt(UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentGridId))
        Dim zMetaGrid As rowTblMetaGrid = TblMetaGrid.LoadByPrimaryKey(zGridId)
        Dim zFullTitle As String = "TUV SUD GRC Connect |"
        'litTitle.Visible = False
        If Not zMetaGrid.colFldGridPageTitle Is Nothing Then
            If zMetaGrid.colFldGridPageTitle.Length > 0 Then
                'litTitle.Text = zMetaGrid.colFldGridPageTitle
                'litTitle.Visible = True
                zFullTitle = zFullTitle & " " & zMetaGrid.colFldGridPageTitle
            End If
        End If
        'litSubTitle.Visible = False
        If Not zMetaGrid.colFldGridPageSubTitle Is Nothing Then
            If zMetaGrid.colFldGridPageSubTitle.Length > 0 Then
                '       litSubTitle.Text = zMetaGrid.colFldGridPageSubTitle
                '      litSubTitle.Visible = True
                zFullTitle = zFullTitle & " " & zMetaGrid.colFldGridPageSubTitle
            End If
        End If
        Page.Title = zFullTitle

        ' GET THE INSTRUCTIONS NOTE
        divContainerContent.Visible = False
        Dim zInstructions As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.NavLocationSelectionText)
        If Not zInstructions = Nothing Then
            If zInstructions.Length > 0 Then
                'divHeaderContainer.Visible = False
                divContainerContent.Visible = True
                lblTopMessage.Text = zInstructions
            End If
        End If
        ' HIDE OR SHOW ICONS
        divLocExtractDownloadChart.Visible = False
        If Not zMetaGrid.colFldReport2Id Is Nothing Then
            If zMetaGrid.colFldReport2Id > 0 Then
                divLocExtractDownloadChart.Visible = True
            End If
        End If
        If Not zMetaGrid.colFldGridPageTitle Is Nothing Then
            ' NEVER SHOW CHART ICON IF RECENT UPDATE OR DOC LIBRARY
            If zMetaGrid.colFldGridPageTitle.ToLower().Contains("recent update") Or zMetaGrid.colFldGridPageTitle.ToLower().Contains("document library") Then
                divLocExtractDownloadChart.Visible = False
            End If
        End If
        divLocExtractDownloadReport.Visible = False
        If Not zMetaGrid.colFldReportId Is Nothing Then
            If zMetaGrid.colFldReportId > 0 Then
                divLocExtractDownloadReport.Visible = True
            End If
        End If
        'DB - 'Sets the FileNo Gsafe value to empty string when user selecting a location
        'The document library grid uses this master page, but we dont want to clear the fileno when nav to that page
        If Not Request.ServerVariables("url").ToLower.Contains("librariesdocumentlibrary.aspx") Then
            GRC.Connect.Libraries.CoreLib.UtilGSafe.ClearLocationNavigationInformation(zGUID)
        End If

        ' SET ANY CURRENCY OVERRIDES IF EXIST
        Dim zUserCurrencyIdParm As String = ""
        If Not Context.Request.QueryString("userCurrencyId") Is Nothing Then
            ServerSide_CurrencyIdFromPrefilter = Context.Request.QueryString("userCurrencyId")
        End If

    End Sub

    ' RAISE AN EVENT FOR THE ICON CLICKS
    Public Sub RaisePostBackEvent1(ByVal eventArgument As String) Implements IPostBackEventHandler.RaisePostBackEvent
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        Select Case eventArgument
            Case "icoMyPreferences_Click"
                Response.Redirect("~/Home_{{VER}}/Grids/FilterPreferences/FilterPreferences.aspx?sid=" & zSafeGUID, False)
            Case "icoSiteMap_Click"
                Response.Redirect("~/Home_{{VER}}/Sitemap/Default.aspx?sid=" & zSafeGUID, False)
            Case "icoAllReports_Click"
                Response.Redirect("~/Home_{{VER}}/Reports/Default.aspx?sid=" & zSafeGUID, False)
            Case "icoAllData_Click"
                Response.Redirect("~/Home_{{VER}}/Exports/Default.aspx?sid=" & zSafeGUID, False)
        End Select

    End Sub

#End Region

#Region "Initialize Controls"
#Region "Page"
    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Init
        'SAID Checker
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()
        If GRC.Connect.Libraries.CoreLib.UtilSAID.IsNotSecureWithCookie(UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.SafeGUID), zSafeGUID, Me.Page) Then
            Response.Redirect("~/Home_{{VER}}/Auth/Resecure.aspx", False)
        End If

        '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/30/2015
        'With Page.ClientScript
        '    .RegisterClientScriptInclude("Grid", "../../Grids/JS/LocationListingsDefault.js")
        '    .RegisterClientScriptInclude("GridMaster", "../../Grids/JS/GridMaster/GridMaster.js")
        '    .RegisterClientScriptInclude("myGrid", "../../Grids/JS/GridMaster/myGrid.js")
        '    .RegisterClientScriptInclude("Panels", "../../Grids/JS/GridMaster/Panels.js")
        '    .RegisterClientScriptInclude("Utility", "../../Grids/JS/GridMaster/Utility.js")
        '    .RegisterClientScriptInclude("Warp", "../../Grids/JS/GridMaster/Warp.js")
        'End With
    End Sub
#End Region

#Region "Warp"
    '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
    'Protected Sub warpGrid_Init(ByVal sender As Object, ByVal e As EventArgs) Handles warpGrid.Init
    '    If Not Page.IsPostBack Then
    '        modGridMasterPageInit.warpGrid_Init(warpGrid, Nothing, Nothing, cboRowsRange)
    '    End If
    'End Sub
#End Region

#Region "Grid"
    '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
    'Protected Sub myGrid_Init(ByVal sender As Object, ByVal e As EventArgs) Handles myGrid.Init
    '    If Not Page.IsPostBack Then
    '        modGrid.ClearSession(True, Request, False)
    '        modGrid.SetGridAppSession(Request)
    '        AppSession.modGrid = New modGrid
    '        modGridMasterPageInit.myGrid_Init(myGrid, Page.IsPostBack)
    '        AppSession.RowsRange = myGrid.DisplayLayout.RowsRange
    '    Else
    '        CheckRowRangeChange()
    '        modGridMasterPageInit.myGrid_Init(myGrid, Page.IsPostBack)
    '    End If
    'End Sub
#End Region
#End Region

#Region "Page Events"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()

        If Not Page.IsPostBack Then
            SetSessionValues()
            FillParameters()
            GRC.Connect.Libraries.CoreLib.UtilFind.ClearFindFields(zSafeGUID)
            Call LoadDefaults()
        Else
            CheckApplyPicklist()
        End If
        Call LoadData()

    End Sub

#Region "Parameters"
    Private Sub SetSessionValues()
        '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
        'AppSession.Practice = AppSession.modMyGrid.Practice()
        'AppSession.FileName = AppSession.modMyGrid.FileName(Request)
        'AppSession.GridName = AppSession.modMyGrid.GridName(Request)
        'AppSession.StoredProcedure = AppSession.modMyGrid.SelectStoredProcedure()
    End Sub

    Private Sub FillParameters()
        '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
        'litTitle.Text = AppSession.modMyGrid.Title()
        'litSubTitle.Text = AppSession.modMyGrid.SubTitle(Request)
        'If litSubTitle.Text = String.Empty Then
        '    litSubTitle.Visible = False
        'End If
        'litPicklistMenu.Text = modGrid.PicklistMenu()
        'If AppSession.HasParameters = True Then
        '    AppSession.modGrid.SaveSessionVariables(String.Empty)
        'End If
        'AppSession.modMyGrid.FillCustomizedColumns()
    End Sub
#End Region

#Region "Postback"
    Private Sub CheckApplyPicklist()
        '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
        'If PicklistControl.Action = modGrid.Picklist Then
        '    AppSession.Column = PicklistControl.SelectedColumn
        'End If
    End Sub
#End Region

    '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
    'Public Sub PageLoadComplete(ByVal request As HttpRequest, ByVal pageIsPostBack As Boolean, ByRef picklistControl As PicklistControl, ByRef myGrid As UltraWebGrid, ByRef pData As Label, ByRef sData As Label, ByRef fData As Label)
    '    picklistControl.PicklistInfo = String.Empty
    '    AppSession.modGrid.SaveSessionVariables(picklistControl.Action)
    '    If Not pageIsPostBack Then
    '        modGrid.SetColumnArray(myGrid)
    '        If AppSession.HasParameters = True Then
    '            UpdateGridDisplay(pageIsPostBack, myGrid, picklistControl.Action, picklistControl.Pin, pData, sData, fData)
    '        Else
    '            FormatGrid(pageIsPostBack, myGrid)
    '        End If
    '    Else
    '        myGrid.DisplayLayout.ActiveRow = Nothing
    '    End If
    '    modGrid.FormatColumn(myGrid, AppSession.modMyGrid)
    '    AppSession.modMyGrid.SpecialHeaderColours(myGrid)
    '    AppSession.HasParameters = False
    'End Sub

    Protected Sub Page_Disposed(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Disposed
        '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
        'modGrid.ClearSession(False, Request, False)
        'AppSession.modGrid = Nothing
        'AppSession.modMyGrid = Nothing
        'myGrid.Dispose()
        'myGrid = Nothing
        'modGlobalFunctions = Nothing
        'modGridMasterPageInit = Nothing
        'dv = Nothing
        'changeRowsRange = Nothing
    End Sub
#End Region

#Region "GridData"
    '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
    'Protected Sub myGrid_InitializeDataSource(ByVal sender As Object, ByVal e As UltraGridEventArgs) Handles myGrid.InitializeDataSource
    '    AppSession.modGrid.SetSessionVariables(PicklistControl.Action)
    '    ResetRowRange()

    '    myGrid.DisplayLayout.LoadOnDemand = LoadOnDemand.Xml

    '    If Not Page.IsPostBack Then
    '        Dim dt As DataTable = modGrid.GetDataTable(AppSession.modMyGrid.GridType, AppSession.StoredProcedure)
    '        AppSession.DataTable = dt
    '        dv = AppSession.DataTable.DefaultView
    '    ElseIf PicklistControl.Action <> modGrid.CBL And PicklistControl.CBLmode <> modGrid.CheckAll And PicklistControl.CBLmode <> modGrid.UncheckAll And PicklistControl.CBLmode <> modGrid.RevertAll Then
    '        dv = AppSession.DataTable.DefaultView
    '    End If
    'End Sub

    'Protected Sub myGrid_DataBinding(ByVal sender As Object, ByVal e As EventArgs) Handles myGrid.DataBinding
    '    If PicklistControl.Action <> modGrid.CBL And PicklistControl.CBLmode <> modGrid.CheckAll And PicklistControl.CBLmode <> modGrid.UncheckAll And PicklistControl.CBLmode <> modGrid.RevertAll Then
    '        If Page.IsPostBack Or AppSession.HasParameters = True Then
    '            If AppSession.HasParameters = True Or PicklistControl.Action = modGrid.Picklist Or PicklistControl.Action = modGrid.Top10 Or PicklistControl.Action = modGrid.Custom Or PicklistControl.Action = modGrid.KillCustom Then
    '                AppSession.modGrid.ProcessSortAndFilters(AppSession.GRCGridColumns, Page, AppSession.modMyGrid, PicklistControl.Picklist, hidMem, PicklistControl.Reset, hidFilter, PicklistControl.PicklistInfo, PicklistControl.Action, PicklistControl.Top10, PicklistControl.CBLmode)
    '            End If
    '            dv.RowFilter = AppSession.FilterSQL
    '            dv.Sort = AppSession.myColumns.GetSortSQL
    '        End If

    '        myGrid.DataSource = dv
    '        NumberOfRecords(dv.Count)
    '    End If
    'End Sub

    Private Sub NumberOfRecords(ByVal numRecords As Integer)
        '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
        'lblRecords.Text = modGrid.GetNumberOfRecordsString(numRecords)
    End Sub

    '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
    'Protected Sub myGrid_InitializeRow(ByVal sender As Object, ByVal e As Infragistics.WebUI.UltraWebGrid.RowEventArgs) Handles myGrid.InitializeRow
    '    If PicklistControl.Action <> modGrid.CBL And PicklistControl.CBLmode <> modGrid.CheckAll And PicklistControl.CBLmode <> modGrid.UncheckAll And PicklistControl.CBLmode <> modGrid.RevertAll Then
    '        'Color the applicable columns
    '        Dim column As String
    '        Dim i As Integer = 0
    '        If AppSession.modGrid.ColorColumns IsNot Nothing Then
    '            Do While i <= AppSession.modGrid.NumColorColumns
    '                If AppSession.modGrid.ColorColumns(i) <> String.Empty Then
    '                    column = AppSession.modGrid.ColorColumns(i)
    '                    e.Row.Cells.FromKey(column).Style.BackColor = AppSession.modMyGrid.SetColors(e, column)
    '                End If
    '                i += 1
    '            Loop
    '        End If

    '        i = 0
    '        If AppSession.modGrid.URLColumns IsNot Nothing Then
    '            Do While i <= AppSession.modGrid.NumURLColumns
    '                If AppSession.modGrid.URLColumns(i) <> String.Empty Then
    '                    column = AppSession.modGrid.URLColumns(i)
    '                    e.Row.Cells.FromKey(column).TargetURL = AppSession.modMyGrid.SetTargetURL(e, column)
    '                    e.Row.Cells.FromKey(column).Text = AppSession.modMyGrid.SetURLText(e, column)
    '                End If
    '                i += 1
    '            Loop
    '        End If

    '        i = Nothing
    '    End If
    'End Sub
#End Region

#Region "Layout"
    '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
    'Private Sub FormatGrid(ByVal pageIsPostBack As Boolean, ByRef myGrid As UltraWebGrid)
    '    Dim calculateDefaultColumnWidth As Boolean = False
    '    With myGrid
    '        Dim numColumns As Integer = .Bands(0).Columns.Count - 1
    '        If Not pageIsPostBack Then
    '            If AppSession.ColumnSize Is Nothing Then
    '                calculateDefaultColumnWidth = True
    '                ReDim AppSession.ColumnSize(numColumns)
    '            End If
    '        End If
    '        For iColumn As Integer = 0 To numColumns
    '            'Header Caption
    '            .Columns(iColumn).Header.Caption = AppSession.modMyGrid.ColumnNames(.Columns(iColumn).Key)
    '            'Set Width using calculated default values and resized based on the size of the data
    '            If Not pageIsPostBack Then
    '                If calculateDefaultColumnWidth Then
    '                    'Fill The Default Column Width Array using the Caption size
    '                    AppSession.ColumnSize(iColumn) = modGrid.DefaultColumnWidth(myGrid, .Columns(iColumn).Header.Caption)
    '                End If
    '                If .Columns.Item(iColumn).DataType <> modGlobalFunctions.SystemDateTime Then
    '                    'Date field, not updated with cell values.
    '                    modGrid.ResizeColumns(myGrid, iColumn)
    '                Else
    '                    'Check Min SystemDateTime width
    '                    If AppSession.ColumnSize(iColumn) < 50 Then
    '                        AppSession.ColumnSize(iColumn) = 50
    '                    End If
    '                End If
    '            End If
    '            'Apply calculated column width
    '            .Columns.Item(iColumn).Width = modGrid.ColumnWidth(.Columns.Item(iColumn).Key)
    '        Next
    '        numColumns = Nothing
    '        'Hide Columns
    '        AppSession.modMyGrid.Hidden(myGrid)
    '    End With
    'End Sub
#End Region

#Region "DisplayGridSettings"
    '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
    'Private Sub UpdateGridDisplay(ByVal PageIsPostBack As Boolean, ByRef myGrid As UltraWebGrid, ByVal action As String, ByVal pin As Boolean, ByRef pData As Label, ByRef sData As Label, ByRef fData As Label)
    '    FormatGrid(PageIsPostBack, myGrid)
    '    If action = modGrid.Picklist Or action = modGrid.Top10 Or action = modGrid.Custom Or action = modGrid.KillCustom Then
    '        AppSession.modGrid.ProcessPins(Page, myGrid, pin)
    '    End If
    '    AppSession.modGrid.ProcessGrid(myGrid)
    '    modGridMasterPage.DisplayGridSettings(pData, sData, fData)
    'End Sub
#End Region

#Region "RowsRange"
    Private Sub CheckRowRangeChange()
        '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
        'If Page.Request.Params.GetValues(modGlobalFunctions.EVENTTARGET)(0).EndsWith(modGrid.RowsRangeControl) Then
        '    Dim item As String = Page.Request.Params.GetValues(modGlobalFunctions.EVENTTARGET)(0)
        '    If Page.Request.Params.Item(item) = modGrid.RowsRangeMin Then
        '        AppSession.RowsRange = modGrid.RowsRangeMin.Split(modGlobalFunctions.Space)(0)
        '    ElseIf Page.Request.Params.Item(item) = modGrid.RowsRangeMax Then
        '        AppSession.RowsRange = modGrid.RowsRangeMax.Split(modGlobalFunctions.Space)(0)
        '    Else
        '        AppSession.RowsRange = Page.Request.Params.Item(item)
        '    End If
        '    item = Nothing
        '    changeRowsRange = True
        'End If
    End Sub

    Private Sub ResetRowRange()
        '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
        'If changeRowsRange = False Then
        '    If PicklistControl.Action = modGrid.Picklist Or PicklistControl.Action = modGrid.Top10 Or PicklistControl.Action = modGrid.Custom Or PicklistControl.Action = modGrid.KillCustom Then
        '        AppSession.RowsRange = modGrid.RowsRangeMin.Split(modGlobalFunctions.Space)(0)
        '        myGrid.DisplayLayout.RowsRange = AppSession.RowsRange
        '    End If
        'Else
        '    changeRowsRange = False
        '    myGrid.DisplayLayout.RowsRange = AppSession.RowsRange
        'End If
    End Sub

    Private Sub ResetCboRowRange()
        '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
        'If PicklistControl.Action = modGrid.Picklist Or PicklistControl.Action = modGrid.Top10 Or PicklistControl.Action = modGrid.Custom Or PicklistControl.Action = modGrid.KillCustom Then
        '    cboRowsRange.SelectedIndex = 0
        'End If
    End Sub
#End Region

#Region "Warp"
    '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
    'Protected Sub warpGrid_ContentRefresh(ByVal sender As Object, ByVal e As EventArgs) Handles warpGrid.ContentRefresh
    '    ResetCboRowRange()
    '    modGridMasterPageInit.myGrid_Init(myGrid, Page.IsPostBack)
    '    UpdateGridDisplay(Page.IsPostBack, myGrid, PicklistControl.Action, PicklistControl.Pin, pData, sData, fData)
    '    PicklistControl.Action = String.Empty
    '    modGridMasterPageInit.warpGrid_Init(warpGrid, Nothing, Nothing, cboRowsRange)
    '    PicklistControl.warpCBL_Init()
    'End Sub
#End Region


End Class