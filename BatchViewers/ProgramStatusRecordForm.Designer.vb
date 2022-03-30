<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgramStatusRecordForm
    Inherits System.Windows.Forms.Form

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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBoxSectionName = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBoxDirectID = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBoxFilter = New Telerik.WinControls.UI.RadTextBox()
        Me.RadTextBoxGridID = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPageView1 = New Telerik.WinControls.UI.RadPageView()
        Me.RadPageViewPageGrids = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadGridViewGrids = New Telerik.WinControls.UI.RadGridView()
        Me.RadPageViewPageFilter = New Telerik.WinControls.UI.RadPageViewPage()
        Me.RadGridViewFilters = New Telerik.WinControls.UI.RadGridView()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.RadButtonSave = New Telerik.WinControls.UI.RadButton()
        Me.RadButtonCancel = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBoxSectionName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBoxDirectID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBoxFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBoxGridID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageView1.SuspendLayout()
        Me.RadPageViewPageGrids.SuspendLayout()
        CType(Me.RadGridViewGrids, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridViewGrids.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPageViewPageFilter.SuspendLayout()
        CType(Me.RadGridViewFilters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridViewFilters.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButtonSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButtonCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(12, 12)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(78, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Section Name:"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(12, 36)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(52, 18)
        Me.RadLabel2.TabIndex = 1
        Me.RadLabel2.Text = "Direct ID:"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(12, 64)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(31, 18)
        Me.RadLabel3.TabIndex = 2
        Me.RadLabel3.Text = "Filter"
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(12, 110)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(44, 18)
        Me.RadLabel4.TabIndex = 3
        Me.RadLabel4.Text = "Grid ID:"
        '
        'RadTextBoxSectionName
        '
        Me.RadTextBoxSectionName.Location = New System.Drawing.Point(96, 12)
        Me.RadTextBoxSectionName.Name = "RadTextBoxSectionName"
        Me.RadTextBoxSectionName.Size = New System.Drawing.Size(232, 20)
        Me.RadTextBoxSectionName.TabIndex = 4
        '
        'RadTextBoxDirectID
        '
        Me.RadTextBoxDirectID.Location = New System.Drawing.Point(96, 38)
        Me.RadTextBoxDirectID.Name = "RadTextBoxDirectID"
        Me.RadTextBoxDirectID.Size = New System.Drawing.Size(80, 20)
        Me.RadTextBoxDirectID.TabIndex = 5
        '
        'RadTextBoxFilter
        '
        Me.RadTextBoxFilter.AutoSize = False
        Me.RadTextBoxFilter.Location = New System.Drawing.Point(96, 64)
        Me.RadTextBoxFilter.Multiline = True
        Me.RadTextBoxFilter.Name = "RadTextBoxFilter"
        Me.RadTextBoxFilter.Size = New System.Drawing.Size(528, 38)
        Me.RadTextBoxFilter.TabIndex = 6
        '
        'RadTextBoxGridID
        '
        Me.RadTextBoxGridID.Location = New System.Drawing.Point(96, 108)
        Me.RadTextBoxGridID.Name = "RadTextBoxGridID"
        Me.RadTextBoxGridID.Size = New System.Drawing.Size(80, 20)
        Me.RadTextBoxGridID.TabIndex = 7
        '
        'RadPageView1
        '
        Me.RadPageView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPageView1.Controls.Add(Me.RadPageViewPageGrids)
        Me.RadPageView1.Controls.Add(Me.RadPageViewPageFilter)
        Me.RadPageView1.Location = New System.Drawing.Point(12, 189)
        Me.RadPageView1.Name = "RadPageView1"
        Me.RadPageView1.SelectedPage = Me.RadPageViewPageFilter
        Me.RadPageView1.Size = New System.Drawing.Size(940, 387)
        Me.RadPageView1.TabIndex = 8
        Me.RadPageView1.Text = "RadPageViewFilters"
        '
        'RadPageViewPageGrids
        '
        Me.RadPageViewPageGrids.Controls.Add(Me.RadGridViewGrids)
        Me.RadPageViewPageGrids.ItemSize = New System.Drawing.SizeF(42.0!, 28.0!)
        Me.RadPageViewPageGrids.Location = New System.Drawing.Point(10, 37)
        Me.RadPageViewPageGrids.Name = "RadPageViewPageGrids"
        Me.RadPageViewPageGrids.Size = New System.Drawing.Size(919, 339)
        Me.RadPageViewPageGrids.Text = "Grids"
        '
        'RadGridViewGrids
        '
        Me.RadGridViewGrids.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGridViewGrids.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.RadGridViewGrids.MasterTemplate.AutoGenerateColumns = False
        Me.RadGridViewGrids.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridViewGrids.Name = "RadGridViewGrids"
        Me.RadGridViewGrids.Size = New System.Drawing.Size(919, 339)
        Me.RadGridViewGrids.TabIndex = 0
        Me.RadGridViewGrids.Text = "RadGridViewGrids"
        '
        'RadPageViewPageFilter
        '
        Me.RadPageViewPageFilter.Controls.Add(Me.RadGridViewFilters)
        Me.RadPageViewPageFilter.ItemSize = New System.Drawing.SizeF(46.0!, 28.0!)
        Me.RadPageViewPageFilter.Location = New System.Drawing.Point(10, 37)
        Me.RadPageViewPageFilter.Name = "RadPageViewPageFilter"
        Me.RadPageViewPageFilter.Size = New System.Drawing.Size(919, 339)
        Me.RadPageViewPageFilter.Text = "Filters"
        '
        'RadGridViewFilters
        '
        Me.RadGridViewFilters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGridViewFilters.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.RadGridViewFilters.MasterTemplate.AutoGenerateColumns = False
        Me.RadGridViewFilters.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.RadGridViewFilters.Name = "RadGridViewFilters"
        Me.RadGridViewFilters.Size = New System.Drawing.Size(919, 339)
        Me.RadGridViewFilters.TabIndex = 1
        Me.RadGridViewFilters.Text = "RadGridView2"
        '
        'RadButtonSave
        '
        Me.RadButtonSave.Location = New System.Drawing.Point(96, 143)
        Me.RadButtonSave.Name = "RadButtonSave"
        Me.RadButtonSave.Size = New System.Drawing.Size(77, 24)
        Me.RadButtonSave.TabIndex = 9
        Me.RadButtonSave.Text = "Save"
        '
        'RadButtonCancel
        '
        Me.RadButtonCancel.Location = New System.Drawing.Point(179, 143)
        Me.RadButtonCancel.Name = "RadButtonCancel"
        Me.RadButtonCancel.Size = New System.Drawing.Size(77, 24)
        Me.RadButtonCancel.TabIndex = 10
        Me.RadButtonCancel.Text = "Cancel"
        '
        'ProgramStatusRecordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 590)
        Me.Controls.Add(Me.RadButtonCancel)
        Me.Controls.Add(Me.RadButtonSave)
        Me.Controls.Add(Me.RadPageView1)
        Me.Controls.Add(Me.RadTextBoxGridID)
        Me.Controls.Add(Me.RadTextBoxFilter)
        Me.Controls.Add(Me.RadTextBoxDirectID)
        Me.Controls.Add(Me.RadTextBoxSectionName)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Name = "ProgramStatusRecordForm"
        Me.Text = "ProgramStatusRecordForm"
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBoxSectionName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBoxDirectID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBoxFilter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBoxGridID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPageView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageView1.ResumeLayout(False)
        Me.RadPageViewPageGrids.ResumeLayout(False)
        CType(Me.RadGridViewGrids.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridViewGrids, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPageViewPageFilter.ResumeLayout(False)
        CType(Me.RadGridViewFilters.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridViewFilters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButtonSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButtonCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBoxSectionName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBoxDirectID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBoxFilter As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadTextBoxGridID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPageView1 As Telerik.WinControls.UI.RadPageView
    Friend WithEvents RadPageViewPageGrids As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadGridViewGrids As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadPageViewPageFilter As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents RadGridViewFilters As Telerik.WinControls.UI.RadGridView
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents RadButtonSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButtonCancel As Telerik.WinControls.UI.RadButton
End Class
