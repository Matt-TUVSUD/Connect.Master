Imports Telerik.WinControls.UI
Imports GRC.Connect.Libraries.DataLib.razor
Imports GRC.Connect.Winforms.UtilityForms.Meta

Public Class MetaUtilityForm
    Implements IUtilityForm

    Public PropertyForm As New MetaPropertyForm(Me)
    Public DataSource As Meta.MetaData.DataSources = MetaData.DataSources.Grids
    Public DefaultTheme As String = "Windows8"

    Public Sub Init()
        Try
            RadGridView1.EnableGrouping = False

            RadMenuItemGrids.Tag = Meta.MetaData.DataSources.Grids
            RadMenuItemColumns.Tag = Meta.MetaData.DataSources.GridColumns
            RadMenuItemCharts.Tag = Meta.MetaData.DataSources.Charts
            RadMenuItemNavLink.Tag = Meta.MetaData.DataSources.NavLinks
            RadMenuItemPS.Tag = Meta.MetaData.DataSources.ProgramStatus
            RadMenuItemSources.Tag = Meta.MetaData.DataSources.Sources
            RadMenuItemColumnTemplate.Tag = Meta.MetaData.DataSources.ColumnTemplate
            RadMenuItemReports.Tag = Meta.MetaData.DataSources.Reports

            AddHandler RadMenuItemGrids.Click, AddressOf RadItemClick
            AddHandler RadMenuItemColumns.Click, AddressOf RadItemClick
            AddHandler RadMenuItemCharts.Click, AddressOf RadItemClick
            AddHandler RadMenuItemNavLink.Click, AddressOf RadItemClick
            AddHandler RadMenuItemPS.Click, AddressOf RadItemClick
            AddHandler RadMenuItemSources.Click, AddressOf RadItemClick
            AddHandler RadMenuItemColumnTemplate.Click, AddressOf RadItemClick
            AddHandler RadMenuItemReports.Click, AddressOf RadItemClick

            AddHandler RadGridView1.CellFormatting, AddressOf CellFormattingHandler
            AddHandler RadGridView1.CellEndEdit, AddressOf CellEndEditHandler
            AddHandler RadGridView1.CurrentRowChanged, AddressOf CurrentRowChangedHandler
            AddHandler RadGridView1.UserAddedRow, AddressOf UserAddedRowHandler
            AddHandler RadGridView1.CommandCellClick, AddressOf CommandCellClickHandler
            AddHandler RadGridView1.ContextMenuOpening, AddressOf ContextMenuOpeningHandler

            Telerik.WinControls.ThemeResolutionService.ApplicationThemeName = DefaultTheme
            SetUpThemes()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub SetUpThemes()
        Me.components.Add(New Telerik.WinControls.Themes.Office2007SilverTheme)
        Me.components.Add(New Telerik.WinControls.Themes.Office2010BlackTheme)
        Me.components.Add(New Telerik.WinControls.Themes.VisualStudio2012LightTheme)
        Me.components.Add(New Telerik.WinControls.Themes.Windows8Theme)

        For Each zComponent As System.ComponentModel.IComponent In Me.components.Components.OfType(Of Telerik.WinControls.RadThemeComponentBase)()
            Dim zRadMenuItem As New RadMenuItem(zComponent.GetType.Name, zComponent)
            AddHandler zRadMenuItem.Click, AddressOf ApplyTheme
            RadMenuItemThemes.Items.Add(zRadMenuItem)
        Next

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        Me.WindowState = Windows.Forms.FormWindowState.Maximized

    End Sub

    Public Sub New(pOwner As Windows.Forms.Form)
        Me.New()
        Me.Owner = pOwner
        Me.WindowState = Windows.Forms.FormWindowState.Normal
    End Sub

    Private Sub MetaUtilityForm_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
        Init()
    End Sub

    Private Sub MetaUtility_Load(sender As Object, e As EventArgs) Handles Me.Load

        If IsNothing(Me.Owner) Then
            Meta.MetaData.LoadData()
        End If

        LoadFormsMenu()
        MakeTemplate()
    End Sub

    Private Sub MakeTemplate()
        Meta.MetaRadGridTemplates.CreateTemplate(DataSource, RadGridView1.MasterTemplate)
        Meta.MetaRadGridTemplates.SetupSubTemplate(RadGridView1.MasterTemplate)
    End Sub

    Private Sub CommandCellClickHandler(sender As Object, e As GridViewCellEventArgs)

        If Not (TypeOf e.Row Is GridViewNewRowInfo) And TypeOf e.Column Is CopyRowCommandButtonColumn Then
            DirectCast(e.Column, CopyRowCommandButtonColumn).CopyRow(e.Row)
            'Else
            '    Dim zChartSeriesDetailRow As rowTblMetaChartSeriesDetail = e.Row.DataBoundItem
            '    Dim zChartSeriesRow As rowTblMetaChartSeries = DirectCast(MetaData.ChartSeries, List(Of rowTblMetaChartSeries)).Find(Function(x) x.colFldId = zChartSeriesDetailRow.colFldMetaChartSeriesId)
            '    Dim zChartRow As rowTblMetaChart = DirectCast(MetaData.Charts, List(Of rowTblMetaChart)).Find(Function(x) x.colFldId = zChartSeriesRow.colFldMetaChartId)
            '    Dim zProgramStatus As List(Of rowTblMetaProgramStatus) = MetaData.ProgramStatus

            '    Dim zPSForm As New ProgramStatusRecordForm
            '    zPSForm.DSGrids = MetaData.Grids
            '    zPSForm.DSPS = MetaData.ProgramStatus
            '    zPSForm.SectionName = "DrillChart " & zChartSeriesDetailRow.colFldId.ToString
            '    zPSForm.ShowDialog()

            '    If zPSForm.DialogResult = Windows.Forms.DialogResult.OK Then
            '        Dim zPS As New rowTblMetaProgramStatus
            '        zPS.colFldFilter = zPSForm.Filter
            '        zPS.colFldSectionName = zPSForm.SectionName
            '        zPS.colFldDirectId = zPSForm.DirectID
            '        zPS.colFldGridId = zPSForm.GridID

            '        TblMetaProgramStatus.Save(zPS)
            '        MetaData.ProgramStatus.Add(zPS)

            '        zChartSeriesDetailRow.colFldMetaChartDrillDownId = zPS.colFldDirectId
            '        TblMetaChartSeriesDetail.Save(zChartSeriesDetailRow)

            ' e.Row.ViewTemplate.Refresh()

        End If

    End Sub

    Private Sub RadGridView1_ContextMenuOpening(sender As Object, e As ContextMenuOpeningEventArgs)
        'Dim zMenu As RadDropDownMenu = e.ContextMenu
        'e.ContextMenu.Items.Clear()

        'Dim zMenuText As String = "Copy Row"
        'If RadGridView1.SelectedRows.Count > 1 Then zMenuText = "Copy Rows (" & RadGridView1.SelectedRows.Count & ")"

        'Dim zItem As New RadMenuItem(zMenuText)
        'AddHandler zItem.Click, AddressOf CopyRowClick
        'zMenu.Items.Add(zItem)

        'If Not IsNothing(_CopyDataBoundType) Then
        '    Dim zClearItem As New RadMenuItem("Clear Copy")
        '    AddHandler zClearItem.Click, AddressOf ClearCopyRowClick

        '    Dim zPasteItem As New RadMenuItem("Paste")
        '    AddHandler zPasteItem.Click, AddressOf PasteRowClick

        '    zMenu.Items.AddRange(zClearItem, zPasteItem)
        'End If


    End Sub

    'Private Sub RadGridView1_CurrentRowChanged(sender As Object, e As CurrentRowChangedEventArgs) Handles RadGridView1.CurrentRowChanged
    '    If e.CurrentRow IsNot Nothing Then
    '        Dim zList As New List(Of Telerik.WinControls.UI.RadPropertyStore)
    '        For Each zCell As GridViewCellInfo In e.CurrentRow.Cells
    '            If TypeOf zCell.ColumnInfo Is Meta.IMetaColumn Then
    '                zList.Add(DirectCast(zCell.ColumnInfo, Meta.IMetaColumn).GetPropertyStore(zCell.Value))
    '            End If
    '        Next
    '        Dim zPropStore As New RadPropertyStore
    '        zList.ForEach(Sub(x) x.ToList.ForEach(Sub(y) zPropStore.Add(y)))
    '        RadPropertyGrid1.SelectedObject = zPropStore
    '    End If

    'End Sub

    'Private Sub RadGridView1_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs)

    '    Select Case e.Action
    '        Case Telerik.WinControls.Data.NotifyCollectionChangedAction.ItemChanged, Telerik.WinControls.Data.NotifyCollectionChangedAction.Add
    '            If Not IsNothing(e.NewItems) Then
    '                For Each zItem As Object In e.NewItems

    '                    If TypeOf zItem.DataBoundItem Is rowTblMetaReport Then
    '                        Dim zObj As rowTblMetaReport = zItem.DataBoundItem
    '                        TblMetaReport.Save(zObj)
    '                    End If

    '                    If TypeOf zItem.DataBoundItem Is rowTblMetaSource Then
    '                        Dim zObj As rowTblMetaSource = zItem.DataBoundItem
    '                        TblMetaSource.Save(zObj)
    '                    End If

    '                    If TypeOf zItem.DataBoundItem Is rowTblMetaGrid Then
    '                        Dim zObj As rowTblMetaGrid = zItem.DataBoundItem
    '                        TblMetaGrid.Save(zObj)
    '                    End If

    '                    If TypeOf zItem.DataBoundItem Is rowTblMetaGridColumn Then
    '                        Dim zObj As rowTblMetaGridColumn = zItem.DataBoundItem
    '                        TblMetaGridColumn.Save(zObj)
    '                    End If

    '                    If TypeOf zItem.DataBoundItem Is rowTblNavLink Then
    '                        Dim zObj As rowTblNavLink = zItem.DataBoundItem
    '                        TblNavLink.Save(zObj)
    '                    End If

    '                    If TypeOf zItem.DataBoundItem Is rowTblMetaGridColumnTemplate Then
    '                        Dim zObj As rowTblMetaGridColumnTemplate = zItem.DataBoundItem
    '                        TblMetaGridColumnTemplate.Save(zObj)
    '                    End If


    '                    If TypeOf zItem.DataBoundItem Is rowTblMetaChart Then
    '                        Dim zObj As rowTblMetaChart = zItem.DataBoundItem
    '                        TblMetaChart.Save(zObj)
    '                    End If

    '                    If TypeOf zItem.DataBoundItem Is rowTblMetaChartSeries Then
    '                        Dim zObj As rowTblMetaChartSeries = zItem.DataBoundItem
    '                        TblMetaChartSeries.Save(zObj)
    '                    End If

    '                    If TypeOf zItem.DataBoundItem Is rowTblMetaChartSeriesDetail Then
    '                        Dim zObj As rowTblMetaChartSeriesDetail = zItem.DataBoundItem
    '                        TblMetaChartSeriesDetail.Save(zObj)
    '                    End If

    '                    If TypeOf zItem.DataBoundItem Is rowTblMetaProgramStatus Then
    '                        Dim zObj As rowTblMetaProgramStatus = zItem.DataBoundItem
    '                        TblMetaProgramStatus.Save(zObj)
    '                    End If


    '                Next
    '            End If

    '        Case Telerik.WinControls.Data.NotifyCollectionChangedAction.Remove
    '            If Not IsNothing(e.OldItems) Then
    '                For Each zItem As Object In e.OldItems
    '                    If TypeOf zItem.DataBoundItem Is rowTblMetaReport Then
    '                        Dim zObj As rowTblMetaReport = zItem.DataBoundItem
    '                        TblMetaReport.Delete(zObj)
    '                    End If

    '                    If TypeOf zItem.DataBoundItem Is rowTblMetaSource Then
    '                        Dim zObj As rowTblMetaSource = zItem.DataBoundItem
    '                        TblMetaSource.Delete(zObj)
    '                    End If

    '                    If TypeOf zItem.DataBoundItem Is rowTblMetaGrid Then
    '                        Dim zObj As rowTblMetaGrid = zItem.DataBoundItem
    '                        TblMetaGrid.Delete(zObj)
    '                    End If

    '                    If TypeOf zItem.DataBoundItem Is rowTblMetaGridColumn Then
    '                        Dim zObj As rowTblMetaGridColumn = zItem.DataBoundItem
    '                        TblMetaGridColumn.Delete(zObj)
    '                    End If

    '                    If TypeOf zItem.DataBoundItem Is rowTblNavLink Then
    '                        Dim zObj As rowTblNavLink = zItem.DataBoundItem
    '                        TblNavLink.Delete(zObj)
    '                    End If

    '                    If TypeOf zItem.DataBoundItem Is rowTblMetaGridColumnTemplate Then
    '                        Dim zObj As rowTblMetaGridColumnTemplate = zItem.DataBoundItem
    '                        TblMetaGridColumnTemplate.Delete(zObj)
    '                    End If


    '                    If TypeOf zItem.DataBoundItem Is rowTblMetaChart Then
    '                        Dim zObj As rowTblMetaChart = zItem.DataBoundItem
    '                        Dim zChartSeries As List(Of rowTblMetaChartSeries) = MetaData.ChartSeries.FindAll(Function(x) x.colFldMetaChartId = zObj.colFldId).ToList()
    '                        For Each zSeries As rowTblMetaChartSeries In zChartSeries
    '                            Dim zChartSeriesDetail As List(Of rowTblMetaChartSeriesDetail) = MetaData.ChartSeriesDetails.FindAll(Function(x) x.colFldMetaChartSeriesId = zSeries.colFldId).ToList()
    '                            For Each zDetail As rowTblMetaChartSeriesDetail In zChartSeriesDetail
    '                                TblMetaChartSeriesDetail.Delete(zDetail)
    '                            Next
    '                            TblMetaChartSeries.Delete(zSeries)
    '                        Next
    '                        TblMetaChart.Delete(zObj)
    '                    End If

    '                    If TypeOf zItem.DataBoundItem Is rowTblMetaChartSeries Then
    '                        Dim zObj As rowTblMetaChartSeries = zItem.DataBoundItem
    '                        TblMetaChartSeries.Delete(zObj)
    '                    End If

    '                    If TypeOf zItem.DataBoundItem Is rowTblMetaChartSeriesDetail Then
    '                        Dim zObj As rowTblMetaChartSeriesDetail = zItem.DataBoundItem
    '                        TblMetaChartSeriesDetail.Delete(zObj)
    '                    End If

    '                    MsgBox("Item Deleted: " & zItem.GetType.ToString())

    '                Next

    '            End If
    '    End Select

    'End Sub

    Private Sub RadMenuItemNavLink_Click(sender As Object, e As EventArgs) Handles RadMenuItemNavLink.Click
        ClearAll()
        DataSource = MetaData.DataSources.NavLinks
        MakeTemplate()
    End Sub

    Private Sub RadItemClick(sender As Object, e As EventArgs) Handles RadMenuItemReports.Click
        ClearAll()
        DataSource = DirectCast(sender, RadMenuItem).Tag
        MakeTemplate()
        AutoSizeColumns()
    End Sub

    Private Sub ClearAll()
        Me.RadGridView1.Templates.Clear()
        Me.RadGridView1.Relations.Clear()
        Me.RadGridView1.Columns.Clear()
    End Sub

    Private Sub AutoSizeColumns(Optional pGridViewTemplate As GridViewTemplate = Nothing)

        Dim zGridViewTemplate As GridViewTemplate = Nothing

        If IsNothing(pGridViewTemplate) Then
            zGridViewTemplate = Me.RadGridView1.MasterTemplate
        Else
            zGridViewTemplate = pGridViewTemplate
        End If

        For Each zcol As GridViewColumn In zGridViewTemplate.Columns
            zcol.BestFit()
        Next

        If zGridViewTemplate.Templates.Count > 0 Then
            For Each zTemplate As GridViewTemplate In zGridViewTemplate.Templates
                AutoSizeColumns(zTemplate)
            Next
        End If

    End Sub

    Private Sub OpenWindow(sender As Object, e As EventArgs)
        System.Windows.Forms.Cursor.Current = Windows.Forms.Cursors.WaitCursor
        Dim zForm As Windows.Forms.Form = Activator.CreateInstance(sender.tag.GetType, New Object() {Me})
        zForm.Show()
    End Sub

    Private Sub ApplyTheme(sender As Object, e As EventArgs)
        Dim zTheme As String = sender.text
        Telerik.WinControls.ThemeResolutionService.ApplicationThemeName = zTheme.Replace("Theme", "")
    End Sub

#Region "Handler functions"

    Private Sub CellFormattingHandler(sender As Object, e As CellFormattingEventArgs)
        If TypeOf e.Row Is GridViewNewRowInfo Then

            e.CellElement.ForeColor = Drawing.Color.Black
            e.CellElement.Font = New System.Drawing.Font("Verdana", 9, Drawing.FontStyle.Bold)

            If TypeOf e.Column Is MetaDataTextBoxColumn Then
                If DirectCast(e.Column, MetaDataTextBoxColumn).IsRequired Then
                    If TypeOf e.Column Is Meta.MetaDataTextBoxColumn Then
                        e.CellElement.DrawBorder = True
                        e.CellElement.BorderWidth = 3
                        e.CellElement.BorderColor = Drawing.Color.Red
                        e.CellElement.BorderColor2 = Drawing.Color.Red
                        e.CellElement.BorderColor3 = Drawing.Color.Red
                        e.CellElement.BorderColor4 = Drawing.Color.Red
                        e.CellElement.BorderRightColor = Drawing.Color.Red
                        e.CellElement.BorderTopColor = Drawing.Color.Red
                        e.CellElement.BorderBottomColor = Drawing.Color.Red
                        e.CellElement.BorderLeftColor = Drawing.Color.Red
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CellEndEditHandler(sender As Object, e As GridViewCellEventArgs)
        Try
            Dim zObj As Object = e.Row.DataBoundItem
            If Not IsNothing(zObj) Then
                If zObj.IsDirty() Then
                    Dim zTableType As Type = zObj.GetTableType
                    zTableType.InvokeMember("Save", Reflection.BindingFlags.Public Or Reflection.BindingFlags.Static Or Reflection.BindingFlags.InvokeMethod, Nothing, Nothing, New Object() {zObj})
                    RadDesktopAlert1.CaptionText = "Cell Updated!!"
                    RadDesktopAlert1.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CurrentRowChangedHandler(sender As Object, e As CurrentRowChangedEventArgs)
        Try
            'If TypeOf e.OldRow Is GridViewDataRowInfo Then
            '    Dim zDataItem As Object = e.OldRow.DataBoundItem
            '    If Not IsNothing(zDataItem) Then
            '        If zDataItem.IsDirty() Then
            '            Dim zTableType As Type = zDataItem.GetTableType
            '            zTableType.InvokeMember("Save", Reflection.BindingFlags.Public Or Reflection.BindingFlags.Static Or Reflection.BindingFlags.InvokeMethod, Nothing, Nothing, New Object() {zDataItem})
            '            RadDesktopAlert1.CaptionText = "Row Updated!!"
            '            RadDesktopAlert1.Show()
            '        End If
            '    End If
            'End If

            'If TypeOf e.CurrentRow Is GridViewDataRowInfo Then
            '    If PropertyForm.Visible Then
            '        Dim zMetaColumn As IMetaIDColumn = DirectCast(PropertyForm.RadPropertyGrid1.SelectedObject, MetaPropertyStore).MetaColumn
            '        Dim zFieldName As String = DirectCast(zMetaColumn, GridViewColumn).FieldName
            '        PropertyForm.LoadProperties(zMetaColumn, e.CurrentRow.Cells(zFieldName).Value)
            '    End If
            'End If

            If TypeOf e.CurrentRow Is GridViewNewRowInfo Then
                For Each zCell As GridViewCellInfo In e.CurrentRow.Cells
                    If TypeOf zCell.ColumnInfo Is Meta.MetaDataTextBoxColumn Then
                        DirectCast(zCell.ColumnInfo, Meta.MetaDataTextBoxColumn).SetNewRowDefaultValues(e.CurrentRow, e.OldRow)
                    End If
                Next
            End If

            If DataSource = MetaData.DataSources.NavLinks And TypeOf e.CurrentRow Is GridViewNewRowInfo Then

                e.CurrentRow.Cells(RadGridView1.Columns("colNavText").Index).Value = "<Required>"
                e.CurrentRow.Cells(RadGridView1.Columns("colNavVisible").Index).Value = True
                e.CurrentRow.Cells(RadGridView1.Columns("colSlideMenuId").Index).Value = MetaData.Navlink.Max(Function(x) x.colSlideMenuId) + 1
                e.CurrentRow.Cells(RadGridView1.Columns("colSlideType").Index).Value = "all"
                e.CurrentRow.Cells(RadGridView1.Columns("colSlideGroupId").Index).Value = MetaData.Navlink.Max(Function(x) x.colSlideGroupId) + 1
                e.CurrentRow.Cells(RadGridView1.Columns("colNavOrder").Index).Value = -1
                e.CurrentRow.Cells(RadGridView1.Columns("colNavBypassFilter").Index).Value = False

                If Not IsNothing(e.CurrentRow.Parent) Then
                    Dim zHRow As GridViewHierarchyRowInfo = e.CurrentRow.Parent
                    Dim zParentNavLink As rowTblNavLink = zHRow.DataBoundItem
                    Trace.WriteLine("Parent Link: " & zParentNavLink.colNavText)

                    Dim zParentSlideMenuId As Integer = zParentNavLink.colSlideMenuId


                    Dim zChildren As List(Of rowTblNavLink) = MetaData.Navlink.FindAll(Function(x) IIf(IsNothing(x.colSlideParentId), -1, x.colSlideParentId) = zParentSlideMenuId)
                    If zChildren.Count > 0 Then
                        e.CurrentRow.Cells(RadGridView1.Columns("colSlideGroupId").Index).Value = zChildren(0).colSlideGroupId
                        e.CurrentRow.Cells(RadGridView1.Columns("colSlideLevelId").Index).Value = zChildren(0).colSlideLevelId
                        e.CurrentRow.Cells(RadGridView1.Columns("colSlideOrder").Index).Value = zChildren.Max(Function(x) x.colSlideOrder) + 1
                        e.CurrentRow.Cells(RadGridView1.Columns("colSlideParentId").Index).Value = zChildren(0).colSlideParentId
                    Else
                        e.CurrentRow.Cells(RadGridView1.Columns("colSlideGroupId").Index).Value = MetaData.Navlink.Max(Function(x) x.colSlideGroupId) + 1
                        e.CurrentRow.Cells(RadGridView1.Columns("colSlideLevelId").Index).Value = zParentNavLink.colSlideLevelId + 1
                        e.CurrentRow.Cells(RadGridView1.Columns("colSlideOrder").Index).Value = 1
                        e.CurrentRow.Cells(RadGridView1.Columns("colSlideParentId").Index).Value = zParentNavLink.colSlideMenuId
                    End If

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub UserAddedRowHandler(sender As Object, e As GridViewRowEventArgs)

        Dim zObj As Object = e.Row.DataBoundItem
        Dim zTableType As Type = zObj.GetTableType
        zTableType.InvokeMember("Save", Reflection.BindingFlags.Public Or Reflection.BindingFlags.Static Or Reflection.BindingFlags.InvokeMethod, Nothing, Nothing, New Object() {zObj})
        RadDesktopAlert1.CaptionText = "New Record Saved!!"
        RadDesktopAlert1.Show()
    End Sub

    Private Sub ContextMenuOpeningHandler(sender As Object, e As ContextMenuOpeningEventArgs)

        If TypeOf e.ContextMenuProvider Is GridDataCellElement Then
            If TypeOf DirectCast(e.ContextMenuProvider, GridDataCellElement).ColumnInfo Is Meta.MetaDataTextBoxColumn Then
                Dim zColumn As Meta.MetaDataTextBoxColumn = DirectCast(e.ContextMenuProvider, GridDataCellElement).ColumnInfo
                zColumn.SetContextMenuItems(e.ContextMenu, e.ContextMenuProvider, Me)
            End If
        End If

    End Sub

#End Region

    Public ReadOnly Property ShowOnMainMenu As Boolean Implements IUtilityForm.ShowOnMainMenu
        Get
            Return True
        End Get
    End Property

    Private Sub RadMenuItemOpenSecondaryForm_Click(sender As Object, e As EventArgs) Handles RadMenuItemOpenSecondaryForm.Click
        Dim zForm As New MetaUtilityForm(Me)
        zForm.Show()
    End Sub

    Private Sub LoadFormsMenu()
        For Each zT As Type In StartupForm.GetFormsToShowOnMainPageTypes()
            Dim zRadMenuItem As New RadMenuItem(zT.Name, zT)
            AddHandler zRadMenuItem.Click, AddressOf OpenWindow
            RadMenuItemWindows.Items.Add(zRadMenuItem)
        Next
    End Sub

    Private Sub RadGridView1_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles RadGridView1.CellClick
        If TypeOf e.Column Is ReportIDMetaDataTextBoxColumn Then
            RadCollapsiblePanel1.Expand()
            Dim zCol As ReportIDMetaDataTextBoxColumn = e.Column
            uxPropertyGrid.SelectedObject = zCol.GetPropertyStore(e.Value)
        End If
    End Sub
End Class
