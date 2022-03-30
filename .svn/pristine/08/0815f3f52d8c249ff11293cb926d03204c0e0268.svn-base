Imports GRC.Connect.Libraries.DataLib.razor
Imports Telerik.WinControls.UI
Imports System.Windows.Forms

Public Class NavLinkForm
    Implements IUtilityForm

    Private _TemplateLevelsCreated As Integer = 0
    Private _DataSource As List(Of rowTblNavLink) = Nothing

    Private Sub NavLinkUtility_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _DataSource = TblNavLink.LoadData
            Me.RadGridView1.AutoGenerateColumns = False
            Me.RadGridView1.DataSource = _DataSource.FindAll(Function(x) IsNothing(x.colSlideMenuId) = False And IsNothing(x.colSlideParentId) = True And x.colNavVisible = True And x.colSlideType = "all").OrderBy(Function(x) x.colSlideOrder).ToList
            AddColumns(Me.RadGridView1.MasterTemplate)
            Me.RadGridView1.MasterTemplate.AutoGenerateColumns = False
            CreateTemplates(Me.RadGridView1.MasterTemplate, _DataSource)
            SetNavlinkIdColumnToReadOnly(RadGridView1.MasterTemplate)
        Catch ex As Exception
            Stop
        End Try
    End Sub

    Private Sub AddColumns(ByRef template)
        With template
            .Columns.Add("colNavLinkId", "Link ID", "colNavLinkId")
            .Columns.Add("colSlideMenuId", "Menu ID", "colSlideMenuId")
            .Columns.Add("colSlideGroupId", "Group ID", "colSlideGroupId")
            .Columns.Add("colSlidelevelId", "Level ID", "colSlidelevelId")
            .Columns.Add("colSlideParentId", "Parent ID", "colSlideParentId")
            .Columns.Add("colSlideOrder", "Order", "colSlideOrder")
            .Columns.Add("colSlideType", "Type", "colSlideType")
            .Columns.Add("colSlideImageClassName", "Class", "colSlideImageClassName")

            Dim zDD1 As New Telerik.WinControls.UI.GridViewComboBoxColumn("colNavText", "colNavText")

            'zDD1.AutoCompleteMode = True
            'zDD1.AllowFiltering = True
            zDD1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
            zDD1.SyncSelectionWithText = True
            zDD1.FilteringMode = GridViewFilteringMode.DisplayMember
            Dim zItems1 As String() = UtilNavLink.GetUniqueNavTexts
            zDD1.HeaderText = "NavText"
            zDD1.DataSource = zItems1
            .Columns.AddRange(zDD1)

            '.Columns.Add("colNavText", "Text", "colNavText")
            .Columns.Add("colNavUrl", "Url", "colNavUrl")
            .Columns.Add("colNavVisible", "Visible", "colNavVisible")
            .Columns.Add("colNavSpcFeature", "Special Feature", "colNavSpcFeature")
            .Columns.Add("colNavGridID", "Grid ID", "colNavGridID")
            .Columns.Add("colNavChartID", "Chart ID", "colNavChartID")
            .Columns.Add("colNavReportID", "Rpt ID", "colNavReportID")
            .Columns.Add("colNavTarget", "Target", "colNavTarget")
            .Columns.Add("colNavType", "NavType", "colNavType")

            Dim zDD As New Telerik.WinControls.UI.GridViewComboBoxColumn("colNavSiteMapKeyWord", "colNavSiteMapKeyWord")
            Dim zItems As String() = UtilNavLink.GetSiteMapKeyWords()
            zDD.HeaderText = "Keywords"
            zDD.DataSource = zItems
            .Columns.AddRange(zDD)

            .AllowColumnResize = True
            .BestFitColumns(BestFitColumnMode.AllCells)
        End With
    End Sub

    Private Sub RadGridView1_ContextMenuOpening(sender As Object, e As ContextMenuOpeningEventArgs) Handles RadGridView1.ContextMenuOpening

        e.Cancel = True

        If TypeOf e.ContextMenuProvider Is Telerik.WinControls.UI.GridDataCellElement Then
            Dim zCell As Telerik.WinControls.UI.GridDataCellElement = e.ContextMenuProvider
            If RadGridView1.Columns.GetColumnByFieldName("colNavGridID")(0).Index = zCell.ColumnIndex Then
                If zCell.Value IsNot Nothing Then
                    ContextMenuStrip1.Items(0).Text = "Get Meta (" & zCell.Value.ToString & ")"
                    ContextMenuStrip1.Items(0).Tag = zCell.Value
                    AddHandler ContextMenuStrip1.ItemClicked, AddressOf ContextMenuStrip1_Clicked
                End If
            End If
        End If


    End Sub

    Private Sub RadGridView1_CurrentRowChanged(sender As Object, e As CurrentRowChangedEventArgs) Handles RadGridView1.CurrentRowChanged

        If Not IsNothing(e.CurrentRow) And Not IsNothing(e.OldRow) Then

            If TypeOf e.CurrentRow Is GridViewNewRowInfo Then

                'SET DEFAULT NEW ROW VALUES

                e.CurrentRow.Cells(RadGridView1.Columns("colNavText").Index).Value = "<Required>"
                e.CurrentRow.Cells(RadGridView1.Columns("colNavVisible").Index).Value = True
                e.CurrentRow.Cells(RadGridView1.Columns("colSlideMenuId").Index).Value = _DataSource.Max(Function(x) x.colSlideMenuId) + 1
                e.CurrentRow.Cells(RadGridView1.Columns("colSlideType").Index).Value = "all"
                e.CurrentRow.Cells(RadGridView1.Columns("colSlideGroupId").Index).Value = _DataSource.Max(Function(x) x.colSlideGroupId) + 1

                If Not IsNothing(e.CurrentRow.Parent) Then
                    Dim zHRow As GridViewHierarchyRowInfo = e.CurrentRow.Parent
                    Dim zParentNavLink As rowTblNavLink = zHRow.DataBoundItem
                    Trace.WriteLine("Parent Link: " & zParentNavLink.colNavText)

                    Dim zParentSlideMenuId As Integer = zParentNavLink.colSlideMenuId


                    Dim zChildren As List(Of rowTblNavLink) = _DataSource.FindAll(Function(x) IIf(IsNothing(x.colSlideParentId), -1, x.colSlideParentId) = zParentSlideMenuId)
                    If zChildren.Count > 0 Then
                        e.CurrentRow.Cells(RadGridView1.Columns("colSlideGroupId").Index).Value = zChildren(0).colSlideGroupId
                        e.CurrentRow.Cells(RadGridView1.Columns("colSlideLevelId").Index).Value = zChildren(0).colSlideLevelId
                        e.CurrentRow.Cells(RadGridView1.Columns("colSlideOrder").Index).Value = zChildren.Max(Function(x) x.colSlideOrder) + 1
                        e.CurrentRow.Cells(RadGridView1.Columns("colSlideParentId").Index).Value = zChildren(0).colSlideParentId
                    Else
                        e.CurrentRow.Cells(RadGridView1.Columns("colSlideGroupId").Index).Value = _DataSource.Max(Function(x) x.colSlideGroupId) + 1
                        e.CurrentRow.Cells(RadGridView1.Columns("colSlideLevelId").Index).Value = zParentNavLink.colSlideLevelId + 1
                        e.CurrentRow.Cells(RadGridView1.Columns("colSlideOrder").Index).Value = 1
                        e.CurrentRow.Cells(RadGridView1.Columns("colSlideParentId").Index).Value = zParentNavLink.colSlideMenuId
                    End If

                End If

            End If

            If TypeOf e.OldRow Is GridViewHierarchyRowInfo Then
                Dim zData As rowTblNavLink = e.OldRow.DataBoundItem
                zData.colNavOrder = -1
                zData.colNavBypassFilter = False
                zData.colIsClientAdmin = False

                If zData.IsDirty Then
                    TblNavLink.Save(zData)
                    Trace.WriteLine("Just saved: " & zData.colNavText)
                    zData.SetIsDirty(False)
                End If
            End If
        End If
    End Sub

    Private Sub RadGridView1_DataBindingComplete(sender As Object, e As Telerik.WinControls.UI.GridViewBindingCompleteEventArgs) Handles RadGridView1.DataBindingComplete
        RadGridView1.BestFitColumns(Telerik.WinControls.UI.BestFitColumnMode.AllCells)
    End Sub

    Private Sub CreateTemplates(pParentTemplate As GridViewTemplate, pDataSource As Object)

        Dim zChildTemplate As New GridViewTemplate
        With zChildTemplate
            .DataSource = pDataSource
            .AutoGenerateColumns = False
            .AllowAutoSizeColumns = True
            .AllowColumnResize = True
            .BestFitColumns(BestFitColumnMode.AllCells)
            .ShowRowHeaderColumn = False
            .Columns.Clear()
            AddColumns(zChildTemplate)
            .Columns.ToList.ForEach(Sub(x) x.AutoSizeMode = BestFitColumnMode.DisplayedCells)
            .Columns.ToList.ForEach(Sub(x) x.BestFit())
        End With

        pParentTemplate.Templates.Add(zChildTemplate)
        CreateRelationShip(pParentTemplate, zChildTemplate)
        _TemplateLevelsCreated += 1

        If _TemplateLevelsCreated < 6 Then
            CreateTemplates(zChildTemplate, pDataSource)
        End If

    End Sub

    Private Sub CreateRelationShip(pParentTemplate As GridViewTemplate, pChildTemplate As GridViewTemplate)
        Dim zRelation As New GridViewRelation(pParentTemplate, pChildTemplate)
        zRelation.ChildColumnNames.Add("colSlideParentId")
        zRelation.ParentColumnNames.Add("colSlideMenuid")
        zRelation.RelationName = "Relation" + _TemplateLevelsCreated.ToString
        Me.RadGridView1.Relations.Add(zRelation)
    End Sub

    Private Sub SetNavlinkIdColumnToReadOnly(pParentTemplate As GridViewTemplate)
        Dim zCols As GridViewDataColumn() = pParentTemplate.Columns.GetColumnByFieldName("colNavLinkId")
        For Each zCol As GridViewDataColumn In zCols
            zCol.ReadOnly = True
        Next

        If pParentTemplate.Templates.Count > 0 Then
            SetNavlinkIdColumnToReadOnly(pParentTemplate.Templates(0))
        End If

    End Sub

    Private Sub RadGridView1_UserAddedRow(sender As Object, e As GridViewRowEventArgs) Handles RadGridView1.UserAddedRow

        'SET DEFAULT VALUES
        Dim zNavLink As rowTblNavLink = e.Row.DataBoundItem
        zNavLink.colNavOrder = -1
        zNavLink.colNavBypassFilter = False
        zNavLink.colIsClientAdmin = False
        zNavLink.colNavLinkId = Nothing

        TblNavLink.Save(zNavLink)
        zNavLink.SetIsDirty(False)

    End Sub

    Private Sub RadGridView1_UserAddingRow(sender As Object, e As GridViewRowCancelEventArgs) Handles RadGridView1.UserAddingRow

        Dim zCols As List(Of GridViewDataColumn) = RadGridView1.Columns.ToList()
        For Each zCol As GridViewDataColumn In zCols
            Dim zCell As GridViewCellInfo = e.Rows(0).Cells(zCol.FieldName)
            If Not IsNothing(zCell.Value) Then
                If zCell.Value.ToString = "<Required>" Then
                    MsgBox(zCol.FieldName & " is a required field.")
                    e.Cancel = True
                End If
            End If
        Next

        If e.Cancel = False Then
            If MsgBox("Save new row?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub RadGridView1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles RadGridView1.PreviewKeyDown
        If e.KeyCode = Keys.Escape Then
            If TypeOf RadGridView1.CurrentRow Is GridViewNewRowInfo Then
                RadGridView1.MasterView.TableAddNewRow.CancelAddNewRow()
            End If
        End If
    End Sub

    Private Sub uxRebind_Click(sender As Object, e As EventArgs) Handles uxRebind.Click


        Dim zFilters As System.Array = RadGridView1.FilterDescriptors.ToArray

        RadGridView1.FilterDescriptors.Clear()
        RadGridView1.Refresh()

        For Each zFilter As Telerik.WinControls.Data.FilterDescriptor In zFilters
            RadGridView1.FilterDescriptors.Add(zFilter)
        Next

        RadGridView1.Refresh()
        MsgBox("Refresh Complete")

    End Sub

    Private Sub RadGridView1_UserDeletingRow(sender As Object, e As GridViewRowCancelEventArgs) Handles RadGridView1.UserDeletingRow
        For Each zRow As GridViewRowInfo In e.Rows
            TblNavLink.Delete(zRow.DataBoundItem)
            MsgBox("Row deleted from database.", MsgBoxStyle.OkOnly)
        Next
    End Sub

    Private Sub RadGridView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles RadGridView1.MouseDoubleClick
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Try
                Dim cell As GridCellElement = RadGridView1.ElementTree.GetElementAtPoint(e.Location)
                If Not IsNothing(cell) Then
                    If cell.ColumnIndex = RadGridView1.Columns.GetColumnByFieldName("colSlideMenuId")(0).Index Then
                        cell.Value = _DataSource.Max(Function(x) x.colSlideMenuId) + 1
                    End If
                End If
            Catch ex As Exception
            End Try
        End If

    End Sub

    Private Sub ContextMenuStrip1_Clicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        'Dim zMeta As New MetaUtilityForm
        'zMeta.GetGridMeta(e.ClickedItem.Tag)
        'zMeta.Show()
    End Sub

    Public ReadOnly Property ShowOnMainMenu As Boolean Implements IUtilityForm.ShowOnMainMenu
        Get
            Return True
        End Get
    End Property
End Class
