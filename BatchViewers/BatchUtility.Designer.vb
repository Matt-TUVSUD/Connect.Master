<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BatchUtility
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.uxBatchSetGrid = New Telerik.WinControls.UI.RadGridView()
        Me.uxBatchSetItemGrid = New Telerik.WinControls.UI.RadGridView()
        Me.CtxMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CtxMenuShowMetaSource = New System.Windows.Forms.ToolStripMenuItem()
        Me.CtxMenuShowMetaGrid = New System.Windows.Forms.ToolStripMenuItem()
        Me.CtxMenuShowMetaReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.uxBatchLogGrid = New Telerik.WinControls.UI.RadGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadRadioButtonShowExceptions = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButtonTodayBatches = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButtonShowAll = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadMenu1 = New Telerik.WinControls.UI.RadMenu()
        Me.RadMenuMetaUtilityForm = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuItemNavLinkUtility = New Telerik.WinControls.UI.RadMenuItem()
        CType(Me.uxBatchSetGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uxBatchSetGrid.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uxBatchSetItemGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uxBatchSetItemGrid.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CtxMenuStrip.SuspendLayout()
        CType(Me.uxBatchLogGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uxBatchLogGrid.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.RadRadioButtonShowExceptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButtonTodayBatches, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButtonShowAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uxBatchSetGrid
        '
        Me.uxBatchSetGrid.Location = New System.Drawing.Point(4, 35)
        '
        '
        '
        Me.uxBatchSetGrid.MasterTemplate.AllowAddNewRow = False
        Me.uxBatchSetGrid.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.uxBatchSetGrid.MasterTemplate.EnableFiltering = True
        Me.uxBatchSetGrid.MasterTemplate.ShowRowHeaderColumn = False
        Me.uxBatchSetGrid.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.uxBatchSetGrid.Name = "uxBatchSetGrid"
        Me.uxBatchSetGrid.ShowGroupPanel = False
        Me.uxBatchSetGrid.Size = New System.Drawing.Size(968, 201)
        Me.uxBatchSetGrid.TabIndex = 0
        Me.uxBatchSetGrid.Text = "RadGridView1"
        '
        'uxBatchSetItemGrid
        '
        Me.uxBatchSetItemGrid.ContextMenuStrip = Me.CtxMenuStrip
        Me.uxBatchSetItemGrid.Location = New System.Drawing.Point(4, 242)
        '
        '
        '
        Me.uxBatchSetItemGrid.MasterTemplate.AllowAddNewRow = False
        Me.uxBatchSetItemGrid.MasterTemplate.AllowCellContextMenu = False
        Me.uxBatchSetItemGrid.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.uxBatchSetItemGrid.MasterTemplate.EnableGrouping = False
        Me.uxBatchSetItemGrid.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.uxBatchSetItemGrid.Name = "uxBatchSetItemGrid"
        Me.uxBatchSetItemGrid.ShowGroupPanel = False
        Me.uxBatchSetItemGrid.Size = New System.Drawing.Size(458, 253)
        Me.uxBatchSetItemGrid.TabIndex = 1
        Me.uxBatchSetItemGrid.Text = "RadGridView2"
        '
        'CtxMenuStrip
        '
        Me.CtxMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.CtxMenuShowMetaSource, Me.CtxMenuShowMetaGrid, Me.CtxMenuShowMetaReport})
        Me.CtxMenuStrip.Name = "ContextMenuStrip1"
        Me.CtxMenuStrip.Size = New System.Drawing.Size(164, 92)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
        Me.ToolStripMenuItem1.Text = "Show Stack..."
        '
        'CtxMenuShowMetaSource
        '
        Me.CtxMenuShowMetaSource.Name = "CtxMenuShowMetaSource"
        Me.CtxMenuShowMetaSource.Size = New System.Drawing.Size(163, 22)
        Me.CtxMenuShowMetaSource.Text = "Show Meta Source"
        '
        'CtxMenuShowMetaGrid
        '
        Me.CtxMenuShowMetaGrid.Name = "CtxMenuShowMetaGrid"
        Me.CtxMenuShowMetaGrid.Size = New System.Drawing.Size(163, 22)
        Me.CtxMenuShowMetaGrid.Text = "Show Meta Grid"
        '
        'CtxMenuShowMetaReport
        '
        Me.CtxMenuShowMetaReport.Name = "CtxMenuShowMetaReport"
        Me.CtxMenuShowMetaReport.Size = New System.Drawing.Size(163, 22)
        Me.CtxMenuShowMetaReport.Text = "Show Meta Report"
        '
        'uxBatchLogGrid
        '
        Me.uxBatchLogGrid.EnableCustomFiltering = True
        Me.uxBatchLogGrid.Location = New System.Drawing.Point(468, 242)
        '
        '
        '
        Me.uxBatchLogGrid.MasterTemplate.AllowAddNewRow = False
        Me.uxBatchLogGrid.MasterTemplate.EnableCustomFiltering = True
        Me.uxBatchLogGrid.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.uxBatchLogGrid.Name = "uxBatchLogGrid"
        Me.uxBatchLogGrid.ShowGroupPanel = False
        Me.uxBatchLogGrid.Size = New System.Drawing.Size(503, 253)
        Me.uxBatchLogGrid.TabIndex = 2
        Me.uxBatchLogGrid.Text = "RadGridView2"
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.RadRadioButtonShowExceptions)
        Me.RadPanel1.Controls.Add(Me.RadRadioButtonTodayBatches)
        Me.RadPanel1.Controls.Add(Me.RadRadioButtonShowAll)
        Me.RadPanel1.Controls.Add(Me.uxBatchSetGrid)
        Me.RadPanel1.Controls.Add(Me.uxBatchLogGrid)
        Me.RadPanel1.Controls.Add(Me.uxBatchSetItemGrid)
        Me.RadPanel1.Location = New System.Drawing.Point(12, 31)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(980, 502)
        Me.RadPanel1.TabIndex = 3
        Me.RadPanel1.Text = "RadPanel1"
        '
        'RadRadioButtonShowExceptions
        '
        Me.RadRadioButtonShowExceptions.Location = New System.Drawing.Point(229, 11)
        Me.RadRadioButtonShowExceptions.Name = "RadRadioButtonShowExceptions"
        Me.RadRadioButtonShowExceptions.Size = New System.Drawing.Size(130, 18)
        Me.RadRadioButtonShowExceptions.TabIndex = 5
        Me.RadRadioButtonShowExceptions.TabStop = False
        Me.RadRadioButtonShowExceptions.Text = "Show Exceptions Only"
        '
        'RadRadioButtonTodayBatches
        '
        Me.RadRadioButtonTodayBatches.Location = New System.Drawing.Point(99, 11)
        Me.RadRadioButtonTodayBatches.Name = "RadRadioButtonTodayBatches"
        Me.RadRadioButtonTodayBatches.Size = New System.Drawing.Size(100, 18)
        Me.RadRadioButtonTodayBatches.TabIndex = 4
        Me.RadRadioButtonTodayBatches.TabStop = False
        Me.RadRadioButtonTodayBatches.Text = "Today's Batches"
        '
        'RadRadioButtonShowAll
        '
        Me.RadRadioButtonShowAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RadRadioButtonShowAll.Location = New System.Drawing.Point(4, 11)
        Me.RadRadioButtonShowAll.Name = "RadRadioButtonShowAll"
        Me.RadRadioButtonShowAll.Size = New System.Drawing.Size(63, 18)
        Me.RadRadioButtonShowAll.TabIndex = 3
        Me.RadRadioButtonShowAll.Text = "Show All"
        Me.RadRadioButtonShowAll.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'RadMenu1
        '
        Me.RadMenu1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuMetaUtilityForm, Me.RadMenuItemNavLinkUtility})
        Me.RadMenu1.Location = New System.Drawing.Point(0, 0)
        Me.RadMenu1.Name = "RadMenu1"
        Me.RadMenu1.Size = New System.Drawing.Size(995, 20)
        Me.RadMenu1.TabIndex = 4
        Me.RadMenu1.Text = "RadMenu1"
        '
        'RadMenuMetaUtilityForm
        '
        Me.RadMenuMetaUtilityForm.Name = "RadMenuMetaUtilityForm"
        Me.RadMenuMetaUtilityForm.Text = "Meta Utility Form"
        '
        'RadMenuItemNavLinkUtility
        '
        Me.RadMenuItemNavLinkUtility.Name = "RadMenuItemNavLinkUtility"
        Me.RadMenuItemNavLinkUtility.Text = "NavLink Utility"
        '
        'BatchUtility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 536)
        Me.Controls.Add(Me.RadMenu1)
        Me.Controls.Add(Me.RadPanel1)
        Me.Name = "BatchUtility"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Main"
        CType(Me.uxBatchSetGrid.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uxBatchSetGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uxBatchSetItemGrid.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uxBatchSetItemGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CtxMenuStrip.ResumeLayout(False)
        CType(Me.uxBatchLogGrid.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uxBatchLogGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.RadRadioButtonShowExceptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButtonTodayBatches, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButtonShowAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uxBatchSetGrid As Telerik.WinControls.UI.RadGridView
    Friend WithEvents uxBatchSetItemGrid As Telerik.WinControls.UI.RadGridView
    Friend WithEvents uxBatchLogGrid As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents CtxMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RadRadioButtonShowExceptions As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButtonTodayBatches As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButtonShowAll As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadMenu1 As Telerik.WinControls.UI.RadMenu
    Friend WithEvents RadMenuMetaUtilityForm As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents CtxMenuShowMetaSource As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CtxMenuShowMetaGrid As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CtxMenuShowMetaReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RadMenuItemNavLinkUtility As Telerik.WinControls.UI.RadMenuItem
End Class

