Imports System
Imports System.Data
Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.DataLib.razor


Partial Class Grids_GridMasterPageFavorites
    Inherits System.Web.UI.MasterPage

#Region "Local Variables"
    'Private modFavorites As New modFavorites
    'Private modGlobalFunctions As New modGlobalFunctions
    'Private modGrid As New modGrid
    'Private modGridMasterPage As New modGridMasterPage
    'Private modGridMasterPageExtract As New modGridMasterPage.Extract
    'Private modGridMasterPageInit As New modGridMasterPage.Init
    'Private dv As DataView

    Private changeCurrency As Boolean = False
    Private changeUnit As Boolean = False
    Private changeRowsRange As Boolean = False
    Public changeCustom As Boolean = False
    Public customConversionValue As String
    Public ServerSide_CurrencyIdFromPrefilter As String = ""
#End Region

#Region "Header Information"
    Private Sub LoadDefaults()
    End Sub

    Private Sub LoadData()
        Dim zGUID As String = UtilGSafe.GetGUIDFromQueryString()

        'SAID Checker
        If GRC.Connect.Libraries.CoreLib.UtilSAID.IsNotSecureWithCookie(UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.SafeGUID), zGUID, Me.Page) Then
            Response.Redirect("~/Home_{{VER}}/Auth/Resecure.aspx", False)
        End If

        ' THIS SUB IS FOR LOADING HEADER INFORMATION AND OTHER NEW DATA
        ' USE OBJECT NAME objGOCSafe
        'lblCompany.Text = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.ClientName)          ' "ABC Company"
        'lblLoginName.Text = GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.userFullName)      ' "Gary Kidney"  
        'lblTodaysDate.Text = FormatDateTime(Date.Today(), DateFormat.LongDate)

        ' GET THE TITLE AND SUBTITLE
        Dim zGridId = CInt(UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.currentGridId))
        Dim zMetaGrid As rowTblMetaGrid = TblMetaGrid.LoadByPrimaryKey(zGridId)
        Dim zFullTitle As String = "TUV SUD GRC Connect |"
        ' GET TITLE
        'litTitle.Visible = False
        If Not zMetaGrid.colFldGridPageTitle Is Nothing Then
            If zMetaGrid.colFldGridPageTitle.Length > 0 Then
                '       litTitle.Text = zMetaGrid.colFldGridPageTitle
                '      litTitle.Visible = True
                zFullTitle = zFullTitle & " " & zMetaGrid.colFldGridPageTitle
            End If
        End If
        ' GET SUBTITLE
        'litSubTitle.Visible = False
        If Not zMetaGrid.colFldGridPageSubTitle Is Nothing Then
            If zMetaGrid.colFldGridPageSubTitle.Length > 0 Then
                '       litSubTitle.Text = zMetaGrid.colFldGridPageSubTitle
                '      litSubTitle.Visible = True
                zFullTitle = zFullTitle & " " & zMetaGrid.colFldGridPageSubTitle
            End If
        End If
        Page.Title = zFullTitle
        ' GET INSTRUCTIONS
        'divTopInstructions.Visible = False
        'If Not zMetaGrid.colFldInstructions Is Nothing Then
        '    divTopInstructions.Visible = True
        '    lblTopMessage.Text = zMetaGrid.colFldInstructions
        'End If
        ' HIDE OR SHOW ICONS
        If Not zMetaGrid.colFldGridPageTitle Is Nothing Then
            If zMetaGrid.colFldGridPageTitle.ToLower().Contains("recent update") Or zMetaGrid.colFldGridPageTitle.ToLower().Contains("document library") Then
                'divExtractDownloadChart.Visible = False
            End If
        End If
        'divExtractDownloadReport.Visible = False
        'If Not zMetaGrid.colFldReportId Is Nothing Then
        '    If zMetaGrid.colFldReportId > 0 Then
        '        divExtractDownloadReport.Visible = True
        '    End If
        'End If

        ' LOOK FOR FILTERS APPLIED
        If GRC.Connect.Libraries.CoreLib.UtilPreference.IsFilterApplied(zGUID) = True Then
            'lblPreferencesApplied.Visible = True
        Else
            'lblPreferencesApplied.Visible = False
        End If

        ' SET ANY CURRENCY OVERRIDES IF EXIST
        Dim zUserCurrencyIdParm As String = ""
        If Not Context.Request.QueryString("userCurrencyId") Is Nothing Then
            ServerSide_CurrencyIdFromPrefilter = Context.Request.QueryString("userCurrencyId")
        End If

    End Sub
#End Region

#Region "Initialize Controls"
#Region "Page"
    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Init
        Dim zSafeGUID As String = UtilGSafe.GetGUIDFromQueryString()

        'SAID Checker
        If GRC.Connect.Libraries.CoreLib.UtilSAID.IsNotSecureWithCookie(UtilGSafe.GetValue(zSafeGUID, UtilGSafe.KeyName.SafeGUID), zSafeGUID, Me.Page) Then
            Response.Redirect("~/Home_{{VER}}/Auth/Resecure.aspx", False)
        End If

        UtilGSafe.SetValue(zSafeGUID, UtilGSafe.KeyName.ExecutedProcedures, Nothing, UtilGSafe.KeyNameGroup.Session) 'For clearing the stored procedure results from previous load.

        With Page.ClientScript
            .RegisterClientScriptInclude("util", "../../../Lib_{{VER}}/pages/util_{{VER}}.js") ' USED FOR BUILDNAVFILELINK
        End With
    End Sub

    Protected Sub hidMasterClientID_Init(ByVal sender As Object, ByVal e As EventArgs) Handles hidMasterClientID.Init
        hidMasterClientID.Value = Page.Master.ClientID
    End Sub
#End Region

#Region "Warp"
    '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
    'Protected Sub warpGrid_Init(ByVal sender As Object, ByVal e As EventArgs) Handles warpGrid.Init
    '    If Not Page.IsPostBack Then
    '        modGridMasterPageInit.warpGrid_Init(warpGrid, cboCurrency, cboUnit, cboRowsRange)
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

#Region "Menu"
    '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
    'Protected Sub myGridWM_Init(ByVal sender As Object, ByVal e As EventArgs) Handles myGridWM.Init
    '    If Not Page.IsPostBack Then
    '        modGridMasterPageInit.myGridWM_Init(myGridWM, Request)
    '    End If
    'End Sub
#End Region

#Region "Favorites"
    '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
    'Protected Sub cmdFavoriteSave_Init(ByVal sender As Object, ByVal e As EventArgs) Handles cmdFavoriteSave.Init
    '    If Not Page.IsPostBack Then
    '        modGridMasterPageInit.cmdFavoriteSave_Init(cmdFavoriteSave)
    '    End If
    'End Sub
    'Protected Sub cmdLibrary_Init(ByVal sender As Object, ByVal e As EventArgs) Handles cmdLibrary.Init
    '    If Not Page.IsPostBack Then
    '        modGridMasterPageInit.cmdLibrary_Init(cmdLibrary)
    '    End If
    'End Sub
#End Region

#Region "Extract"
    '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
    'Protected Sub cmdChart_Init(ByVal sender As Object, ByVal e As EventArgs) Handles cmdChart.Init
    '    If Not Page.IsPostBack Then
    '        modGridMasterPageInit.cmdChart_Init(cmdChart)
    '    End If
    'End Sub
    'Protected Sub cmdReport_Init(ByVal sender As Object, ByVal e As EventArgs) Handles cmdReport.Init
    '    If Not Page.IsPostBack Then
    '        modGridMasterPageInit.cmdReport_Init(cmdReport)
    '    End If
    'End Sub
    'Protected Sub cmdExtractData_Init(ByVal sender As Object, ByVal e As EventArgs) Handles cmdExtractData.Init
    '    If Not Page.IsPostBack Then
    '        modGridMasterPageInit.cmdExtractData_Init(cmdExtractData, Request, 0)
    '    End If
    'End Sub
    'Protected Sub myGridEE_Init(ByVal sender As Object, ByVal e As EventArgs) Handles myGridEE.Init
    '    If Not Page.IsPostBack Then
    '        modGridMasterPageInit.myGridEE_Init(myGridEE)
    '    End If
    'End Sub
#End Region

#Region "Reset"
    'Protected Sub cmdReset_Init(ByVal sender As Object, ByVal e As EventArgs) Handles cmdReset.Init
    '    ***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
    '    If Not Page.IsPostBack Then
    '        modGridMasterPageInit.cmdReset_Init(cmdReset)
    '    End If
    'End Sub
#End Region

#Region "ClosePage"
    'Protected Sub cmdClosePage_Init(ByVal sender As Object, ByVal e As EventArgs) Handles cmdClosePage.Init
    '    ***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
    '    If Not Page.IsPostBack Then
    '        modGridMasterPageInit.cmdClosePage_Init(cmdClosePage)
    '    End If
    'End Sub
#End Region
#End Region

#Region "Page Events"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
        'If modGlobalFunctions.SessionTimeout(Response) = False Then
        '    If Not Page.IsPostBack Then
        '        modGridMasterPageInit.cmdChart_Init_ClientSideEvents(cmdChart)
        '        modGridMasterPageInit.cmdChart_Init_Visible(cmdChart)
        '        modGridMasterPageInit.lblChart_Init_Visible(lblChart)

        '        modGridMasterPageInit.cmdReport_Init_ClientSideEvents(cmdReport)
        '        modGridMasterPageInit.cmdReport_Init_Visible(cmdReport)
        '        modGridMasterPageInit.lblReport_Init_Visible(lblReport)

        '        modGridMasterPageInit.myGrid_Init_RowSelectorStyleDefault(myGrid)
        '        modGridMasterPageInit.myGrid_Init_ClientSideEvents(myGrid)

        '        LoadSelectedFavorite()
        '        SetSessionValues()
        '        FillParameters()
        '        modGrid.WindowOnLoad(Page)

        '        Call LoadDefaults()
        '    Else
        '        FavoriteSaveControl.FavoriteAction()
        '        CheckApplyPicklist()
        '    End If

        '    Call LoadData()
        'End If

        LoadSelectedFavorite()
        SetSessionValues()
        FillParameters()
        Call LoadDefaults()
        Call LoadData()

    End Sub

#Region "Parameters"
    Private Sub LoadSelectedFavorite()
        '***GRC.Connect.STB - REMOVED I.G. RELATED CODE 8/5/2015
        'If AppSession.Favorite > 0 Then
        '    modFavorites.GetFavorite()
        '    AppSession.LoadFavorite = True
        '    AppSession.Favorite = Nothing
        '    AppSession.FavoriteApplied = True
        'End If
    End Sub

    Private Sub SetSessionValues()
        'AppSession.Practice = AppSession.modMyGrid.Practice()
        'AppSession.FileName = AppSession.modMyGrid.FileName(Request)
        'AppSession.GridName = AppSession.modMyGrid.GridName(Request)

        'If AppSession.modMyGrid.GridType = modGrid.GridTypes.TypeRecommendationResponses _
        '    Or AppSession.modMyGrid.GridType = modGrid.GridTypes.TypeRecommendations _
        '    Or AppSession.modMyGrid.GridType = modGrid.GridTypes.TypeStandard _
        '    Or AppSession.modMyGrid.GridType = modGrid.GridTypes.TypeStandardTelerik _
        '    Or AppSession.modMyGrid.GridType = modGrid.GridTypes.TypeTelerik _
        '    Or AppSession.modMyGrid.GridType = modGrid.GridTypes.TypeTelerikUsingSafeGUID _
        '    Or AppSession.modMyGrid.GridType = modGrid.GridTypes.TypeFireImpairments _
        '    Or AppSession.modMyGrid.GridType = modGrid.GridTypes.TypeQoR Then

        '    AppSession.ReportName = AppSession.modMyGrid.ReportName()
        'End If

        'If AppSession.modMyGrid.GridType = modGrid.GridTypes.TypeFacilityRating Then
        '    AppSession.StoredProcedure = AppSession.modMyGrid.SelectStoredProcedure(AppSession.InspectionProgramYear)
        'ElseIf AppSession.modMyGrid.GridType = modGrid.GridTypes.TypeRecommendations Then
        '    AppSession.StoredProcedure = AppSession.modMyGrid.SelectStoredProcedure(Request)
        'Else
        '    AppSession.StoredProcedure = AppSession.modMyGrid.SelectStoredProcedure()
        'End If

        'modGrid.SetHasSort(Request)
    End Sub

    Private Sub FillParameters()
        'litTitle.Text = AppSession.modMyGrid.Title()
        'litSubTitle.Text = AppSession.modMyGrid.SubTitle(Request)
        'If litSubTitle.Text = String.Empty Then
        '    litSubTitle.Visible = False
        'End If

        'litPicklistMenu.Text = modGrid.PicklistMenu()
        'hidSIDParameter.Value = AppSession.SafeGUID
        'cboCurrency.SelectedValue = AppSession.Currency
        'cboUnit.SelectedValue = AppSession.Unit

        'modGridMasterPageInit.lblCurrency_Init(lblCurrency)
        'modGridMasterPageInit.cboCurrency_Init(cboCurrency)
        'modGridMasterPageInit.lblUnit_Init(lblUnit)
        'modGridMasterPageInit.cboUnit_Init(cboUnit)

        'If AppSession.HasParameters Then
        '    AppSession.modGrid.SaveSessionVariables(String.Empty)
        'End If
        'AppSession.modMyGrid.FillCustomizedColumns()
    End Sub
#End Region

#Region "Postback"
    Private Sub CheckApplyPicklist()
        'If PicklistControl.Action = modGrid.Picklist Then
        '    AppSession.Column = PicklistControl.SelectedColumn
        'End If
    End Sub
#End Region

    'Public Sub PageLoadComplete(ByVal request As HttpRequest, ByVal pageIsPostBack As Boolean, ByRef picklistControl As PicklistControl, ByRef myGrid As UltraWebGrid, ByRef pData As Label, ByRef sData As Label, ByRef fData As Label)
    '    ResetCurrency()
    '    ResetUnit()

    '    picklistControl.PicklistInfo = String.Empty
    '    AppSession.modGrid.SaveSessionVariables(picklistControl.Action)
    '    If Not pageIsPostBack Then
    '        modGrid.SetColumnArray(myGrid)

    '        If AppSession.HasSort Then
    '            AppSession.modGrid.SortString(request, myGrid)
    '        End If

    '        If AppSession.LoadFavorite Or AppSession.HasParameters Or AppSession.HasSort Then
    '            UpdateGridDisplay(pageIsPostBack, myGrid, picklistControl.Action, picklistControl.Pin, pData, sData, fData)
    '        Else
    '            FormatGrid(pageIsPostBack, myGrid)
    '        End If
    '    Else
    '        myGrid.DisplayLayout.ActiveRow = Nothing
    '    End If
    '    modGrid.FormatColumn(myGrid, AppSession.modMyGrid)
    '    AppSession.modMyGrid.SpecialHeaderColours(myGrid)

    '    If myGrid.DataSource IsNot Nothing Then
    '        Dim numRecords As Integer = myGrid.DataSource.Count()
    '        If modGridMasterPageInit.AllowInfragisticsExcelExport(numRecords) = False And modGridMasterPageInit.ActiveReportExcelExportExists(request, numRecords) Then
    '            If pageIsPostBack = False Then
    '                modGridMasterPageExtract.CreateExtractColumnCollection(myGrid)
    '            Else
    '                modGridMasterPageExtract.UpdateExtractColumnCollection(myGrid)
    '            End If
    '        End If
    '        numRecords = Nothing
    '    End If

    '    AppSession.HasParameters = False
    '    AppSession.HasSort = False
    '    AppSession.ResetGrid = False
    'End Sub

    Protected Sub Page_Disposed(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Disposed
        'modGrid.ClearSession(False, Request, False)
        'AppSession.modGrid = Nothing
        'AppSession.modMyGrid = Nothing

        'myGridEE.Dispose()
        'myGridEE = Nothing
        'myGrid.Dispose()
        'myGrid = Nothing

        'modFavorites = Nothing
        'modGlobalFunctions = Nothing
        'modGrid = Nothing
        'modGridMasterPage = Nothing
        'modGridMasterPageExtract = Nothing
        'modGridMasterPageInit = Nothing

        'dv = Nothing
        'changeCurrency = Nothing
        'changeUnit = Nothing
        'changeRowsRange = Nothing
        'changeCustom = Nothing
        'customConversionValue = Nothing
    End Sub
#End Region

#Region "GridData"
    'Protected Sub myGrid_InitializeDataSource(ByVal sender As Object, ByVal e As UltraGridEventArgs) Handles myGrid.InitializeDataSource
    '    AppSession.modGrid.SetSessionVariables(PicklistControl.Action)
    '    ResetRowRange()

    '    If AppSession.Email Then
    '        myGrid.DisplayLayout.LoadOnDemand = LoadOnDemand.NotSet
    '    Else
    '        myGrid.DisplayLayout.LoadOnDemand = LoadOnDemand.Xml
    '    End If

    '    If Not Page.IsPostBack Then
    '        Dim dt As DataTable = modGrid.GetDataTable(AppSession.modMyGrid.GridType, AppSession.StoredProcedure)
    '        AppSession.DataTable = dt
    '        dv = AppSession.DataTable.DefaultView
    '    ElseIf PicklistControl.Action <> modGrid.CBL And PicklistControl.CBLmode <> modGrid.CheckAll And PicklistControl.CBLmode <> modGrid.UncheckAll And PicklistControl.CBLmode <> modGrid.RevertAll Then
    '        dv = AppSession.DataTable.DefaultView
    '    End If
    'End Sub

    'Protected Sub myGrid_DataBinding(ByVal sender As Object, ByVal e As EventArgs) Handles myGrid.DataBinding
    '    If PicklistControl.Action <> modGrid.CBL And PicklistControl.CBLmode <> modGrid.CheckAll And PicklistControl.CBLmode <> modGrid.UncheckAll And PicklistControl.CBLmode <> modGrid.RevertAll And changeCurrency = False And changeUnit = False Then
    '        If Page.IsPostBack Or AppSession.LoadFavorite Or AppSession.HasParameters Or AppSession.HasSort Then
    '            CheckCurrencyChange()
    '            CheckUnitChange()
    '            ResetRowRange()
    '            If changeCurrency Or changeUnit Or changeCustom Or AppSession.LoadFavorite Or AppSession.HasParameters Or PicklistControl.Action = modGrid.Picklist Or PicklistControl.Action = modGrid.Top10 Or PicklistControl.Action = modGrid.Custom Or PicklistControl.Action = modGrid.KillCustom Or InfragisticsExcelExportDeniedControl.Action = modGrid.ExtractDenied Then
    '                AppSession.modGrid.ProcessSortAndFilters(AppSession.GRCGridColumns, Page, AppSession.modMyGrid, PicklistControl.Picklist, hidMem, PicklistControl.Reset, hidFilter, PicklistControl.PicklistInfo, PicklistControl.Action, PicklistControl.Top10, PicklistControl.CBLmode)
    '            End If
    '            dv.RowFilter = AppSession.FilterSQL

    '            If AppSession.HasSort Then
    '                dv.Sort = AppSession.modGrid.Sort(Request)
    '            Else
    '                dv.Sort = AppSession.myColumns.GetSortSQL
    '            End If
    '        End If

    '        myGrid.DataSource = dv
    '        NumberOfRecords(dv.Count)
    '    End If
    'End Sub

    Private Sub NumberOfRecords(ByVal numRecords As Integer)
        'lblRecords.Text = modGrid.GetNumberOfRecordsString(numRecords)
        'modGridMasterPageInit.cmdExtractData_Init(cmdExtractData, Request, numRecords)
    End Sub

    Private Sub CheckCurrencyChange()
        'If Page.IsPostBack Then
        '    If Page.Request.Params.GetValues(modGlobalFunctions.EVENTTARGET)(0).EndsWith(modGrid.CurrencyControl) Then
        '        'do the currency change stuff here
        '        changeCurrency = True
        '        If myGrid.Columns.Count = 0 Then
        '            myGrid.DataSource = dv
        '            myGrid.DataBind()
        '        End If

        '        Dim item As String = Page.Request.Params.GetValues(modGlobalFunctions.EVENTTARGET)(0)
        '        AppSession.Currency = Page.Request.Params.Item(item)
        '        AppSession.modGrid.SwitchCurrency(myGrid, AppSession.modMyGrid)
        '        modGridMasterPage.CheckFavoriteApplied(Page.IsPostBack)
        '    End If
        'End If
    End Sub

    Private Sub CheckUnitChange()
        'If Page.IsPostBack Then
        '    If Page.Request.Params.GetValues(modGlobalFunctions.EVENTTARGET)(0).EndsWith(modGrid.UnitControl) Then
        '        'do the unit change stuff here
        '        changeUnit = True
        '        If myGrid.Columns.Count = 0 Then
        '            myGrid.DataSource = dv
        '            myGrid.DataBind()
        '        End If

        '        Dim item As String = Page.Request.Params.GetValues(modGlobalFunctions.EVENTTARGET)(0)
        '        AppSession.Unit = Page.Request.Params.Item(item)
        '        AppSession.modGrid.SwitchUnit(myGrid, AppSession.modMyGrid)
        '        modGridMasterPage.CheckFavoriteApplied(Page.IsPostBack)
        '    End If
        'End If
    End Sub

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
    '                    Dim targetURL As String = AppSession.modMyGrid.SetTargetURL(e, column)
    '                    If targetURL IsNot Nothing Then
    '                        e.Row.Cells.FromKey(column).TargetURL = targetURL
    '                        e.Row.Cells.FromKey(column).Text = AppSession.modMyGrid.SetURLText(e, column)
    '                    End If
    '                End If
    '                i += 1
    '            Loop
    '        End If

    '        'THIS BLOCK OF CODE SIMPLY USES AND PLANTCOMMENTLINEBREAK FIELD FOR THE TOOLTIP IN PLANTCOMMENT COLUMN
    '        'APPLIES FOR RECOMMENDATION GRIDS ONLY
    '        If TypeOf AppSession.modMyGrid Is modGrid.Recommendations.Fire Or
    '            TypeOf AppSession.modMyGrid Is modGrid.Recommendations.BM Or
    '            TypeOf AppSession.modMyGrid Is modGrid.Recommendations.IR Or
    '            TypeOf AppSession.modMyGrid Is modGrid.Recommendations.NatHaz Or
    '            TypeOf AppSession.modMyGrid Is modGrid.RecommendationResponses.Tracking.BM Or
    '            TypeOf AppSession.modMyGrid Is modGrid.RecommendationResponses.Tracking.Fire Or
    '            TypeOf AppSession.modMyGrid Is modGrid.RecommendationResponses.Tracking.IR Or
    '            TypeOf AppSession.modMyGrid Is modGrid.RecommendationResponses.Tracking.NatHaz Then
    '            If myGrid.Bands(0).Columns.Count <> 0 Then
    '                Dim zPlantCommentIdx As Integer = myGrid.Bands(0).Columns.FromKey("PlantComment").Index
    '                Dim zPlantCommentLBIdx As Integer = myGrid.Bands(0).Columns.FromKey("PlantCommentLineBreak").Index
    '                e.Row.Cells(zPlantCommentIdx).TitleMode = CellTitleMode.Always
    '                e.Row.Cells(zPlantCommentIdx).Title = e.Row.Cells(zPlantCommentLBIdx).Value
    '            End If
    '        End If


    '        If TypeOf AppSession.modMyGrid Is Imodgrid Then
    '            If myGrid.Bands(0).Columns.Count <> 0 Then
    '                AppSession.modMyGrid.FormatRow(e.Row)
    '            End If
    '        End If

    '        i = Nothing
    '    End If
    'End Sub
#End Region

#Region "Layout"
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
    '            Diagnostics.Trace.WriteLine("GRID COLUMN: " & .Columns(iColumn).BaseColumnName & " datatype=" & .Columns(iColumn).DataType.ToString)
    '        Next
    '        numColumns = Nothing

    '        'Hide Columns
    '        AppSession.modMyGrid.Hidden(myGrid)
    '        If TypeOf AppSession.modMyGrid Is IModGridUserDefinableLabel Then AppSession.modMyGrid.HideUserDefinableColumns(myGrid)

    '        'Hide columns applying to Currencies other than the selected Currency
    '        If AppSession.modMyGrid.UseCurrency() Then
    '            AppSession.modMyGrid.SetCurrency(myGrid)
    '        End If

    '        'Hide columns applying to Units other than the selected Unit
    '        If AppSession.modMyGrid.UseUnit() Then
    '            AppSession.modMyGrid.SetUnit(myGrid)
    '        End If
    '    End With
    'End Sub
#End Region

#Region "DisplayGridSettings"
    'Private Sub UpdateGridDisplay(ByVal PageIsPostBack As Boolean, ByRef myGrid As UltraWebGrid, ByVal action As String, ByVal pin As Boolean, ByRef pData As Label, ByRef sData As Label, ByRef fData As Label)
    '    FormatGrid(PageIsPostBack, myGrid)

    '    If AppSession.LoadFavorite Or action = modGrid.Picklist Or action = modGrid.Top10 Or action = modGrid.Custom Or action = modGrid.KillCustom Then
    '        AppSession.modGrid.ProcessPins(Page, myGrid, pin)
    '    ElseIf PageIsPostBack And AppSession.HasParameters = False Then
    '        If InfragisticsExcelExportDeniedControl.Action = modGrid.ExtractDenied Then
    '            AppSession.modGrid.ProcessPins(Page, myGrid, pin)
    '        End If
    '    End If

    '    AppSession.modGrid.ProcessGrid(myGrid)
    '    modGridMasterPage.DisplayGridSettings(pData, sData, fData)
    'End Sub
#End Region

#Region "Currency/Unit Conversion"
    Private Sub ResetCurrency()
        If changeCurrency Then
            'Change Selected Currency, and hide columns applying to other Currencies
            'cboCurrency.SelectedIndex = modGlobalFunctions.GetCurrencyIndex(AppSession.Currency)
            changeCurrency = False
        End If
    End Sub

    Private Sub ResetUnit()
        If changeUnit Then
            'Change Selected Unit, and hide columns applying to other Units
            'cboUnit.SelectedIndex = modGlobalFunctions.GetUnitIndex(AppSession.Unit)
            changeUnit = False
        End If
    End Sub
#End Region

#Region "Extract"
    'Protected Sub cmdExtractData_Click(ByVal sender As Object, ByVal e As ButtonEventArgs) Handles cmdExtractData.Click
    '    If modGlobalFunctions.SessionTimeout(Response) = False Then
    '        Dim zUseNewExtract As Boolean = False
    '        ' Use alternate Excel extract method for Calpine for this one extract
    '        If AppSession.FilePreFix = 2594 And AppSession.GridName = "ActiveFireRecommendations" Then zUseNewExtract = True
    '        If AppSession.FilePreFix = 1754 Then zUseNewExtract = True
    '        If AppSession.FilePreFix = 92 Then zUseNewExtract = True
    '        zUseNewExtract = True 'Use the new Excel extract for ALL clients per GK and MB on 10/8/2013
    '        If zUseNewExtract Then
    '            myGrid.DisplayLayout.LoadOnDemand = LoadOnDemand.NotSet
    '            myGrid.DataBind()

    '            Dim zEE As New GRC.Connect.Web.GRCMSOfficeExcel
    '            Dim zSheetName As String = AppSession.FileName
    '            Dim zStream As System.IO.MemoryStream = New System.IO.MemoryStream(zEE.ExportToExcel(dv, zSheetName, myGrid))

    '            Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
    '            Response.AddHeader("content-disposition", "attachment;  filename=" & AppSession.FileName & ".xlsx")
    '            Response.OutputStream.Write(zStream.ToArray(), 0, zStream.ToArray().Length)
    '            Response.Flush()
    '            Response.End()
    '            Response.Close()
    '        Else
    '            If modGridMasterPageInit.AllowInfragisticsExcelExport(dv.Count) Then
    '                modGridMasterPageInit.myGrid_Init(myGrid, False)
    '                FormatGrid(Page.IsPostBack, myGrid)
    '                AppSession.modGrid.ProcessPins(Page, myGrid, PicklistControl.Pin)
    '                AppSession.modMyGrid.SpecialHeaderColours(myGrid)
    '                myGrid.DisplayLayout.LoadOnDemand = LoadOnDemand.NotSet
    '                myGrid.DataBind()
    '                myGridEE.DownloadName = AppSession.FileName
    '                myGridEE.Export(myGrid)
    '            End If
    '        End If
    '    End If
    'End Sub

    'Protected Sub myGridEE_HeaderCellExporting(ByVal sender As Object, ByVal e As HeaderCellExportingEventArgs) Handles myGridEE.HeaderCellExporting
    '    e.HeaderText = modGrid.StripHTML(e.HeaderText)
    'End Sub

    'Protected Sub myGridEE_CellExported(ByVal sender As Object, ByVal e As CellExportedEventArgs) Handles myGridEE.CellExported
    '    modGridMasterPage.myGridEE_CellExported(e)
    'End Sub
#End Region

#Region "Reset"
    'Protected Sub cmdReset_Click(ByVal sender As Object, ByVal e As Infragistics.WebUI.WebDataInput.ButtonEventArgs) Handles cmdReset.Click
    '    If modGlobalFunctions.SessionTimeout(Response) = False Then
    '        modGridMasterPage.Reset(Request, Response)
    '    End If
    'End Sub
#End Region

#Region "RowsRange"
    'Private Sub CheckRowRangeChange()
    '    If Page.Request.Params.GetValues(modGlobalFunctions.EVENTTARGET)(0).EndsWith(modGrid.RowsRangeControl) Then
    '        Dim item As String = Page.Request.Params.GetValues(modGlobalFunctions.EVENTTARGET)(0)
    '        If Page.Request.Params.Item(item) = modGrid.RowsRangeMin Then
    '            AppSession.RowsRange = modGrid.RowsRangeMin.Split(modGlobalFunctions.Space)(0)
    '        ElseIf Page.Request.Params.Item(item) = modGrid.RowsRangeMax Then
    '            AppSession.RowsRange = modGrid.RowsRangeMax.Split(modGlobalFunctions.Space)(0)
    '        Else
    '            AppSession.RowsRange = Page.Request.Params.Item(item)
    '        End If
    '        item = Nothing
    '        changeRowsRange = True
    '    End If
    'End Sub

    'Private Sub ResetRowRange()
    '    If changeRowsRange = False Then
    '        If changeCurrency Or changeUnit Or changeCustom Or PicklistControl.Action = modGrid.Picklist Or PicklistControl.Action = modGrid.Top10 Or PicklistControl.Action = modGrid.Custom Or PicklistControl.Action = modGrid.KillCustom Or InfragisticsExcelExportDeniedControl.Action = modGrid.ExtractDenied Then
    '            AppSession.RowsRange = modGrid.RowsRangeMin.Split(modGlobalFunctions.Space)(0)
    '            myGrid.DisplayLayout.RowsRange = AppSession.RowsRange
    '        End If
    '    Else
    '        changeRowsRange = False
    '        myGrid.DisplayLayout.RowsRange = AppSession.RowsRange
    '    End If
    'End Sub

    'Private Sub ResetCboRowRange()
    '    If changeCurrency Or changeUnit Or changeCustom Or PicklistControl.Action = modGrid.Picklist Or PicklistControl.Action = modGrid.Top10 Or PicklistControl.Action = modGrid.Custom Or PicklistControl.Action = modGrid.KillCustom Or InfragisticsExcelExportDeniedControl.Action = modGrid.ExtractDenied Then
    '        cboRowsRange.SelectedIndex = 0
    '    End If
    'End Sub
#End Region

#Region "Warp"
    'Protected Sub warpGrid_ContentRefresh(ByVal sender As Object, ByVal e As EventArgs) Handles warpGrid.ContentRefresh
    '    ResetCboRowRange()
    '    modGridMasterPageInit.myGrid_Init(myGrid, Page.IsPostBack)
    '    UpdateGridDisplay(Page.IsPostBack, myGrid, PicklistControl.Action, PicklistControl.Pin, pData, sData, fData)
    '    PicklistControl.Action = String.Empty
    '    modGridMasterPageInit.warpGrid_Init(warpGrid, cboCurrency, cboUnit, cboRowsRange)
    '    PicklistControl.warpCBL_Init()
    'End Sub
#End Region

#Region "Close"
    'Protected Sub cmdClosePage_Click(ByVal sender As Object, ByVal e As ButtonEventArgs) Handles cmdClosePage.Click
    '    modGrid.ClearSession(False, Request, False)
    'End Sub
#End Region

End Class