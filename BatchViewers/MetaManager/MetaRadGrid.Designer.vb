<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MetaRadGrid
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.uxMetaGrid = New Telerik.WinControls.UI.RadGridView()
        Me.uxFilter = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.uxSaveGridSettings = New Telerik.WinControls.UI.RadButton()
        Me.uxShowColumnChooser = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        CType(Me.uxMetaGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uxMetaGrid.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uxFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uxSaveGridSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uxShowColumnChooser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'uxMetaGrid
        '
        Me.uxMetaGrid.ColumnChooserSortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
        Me.uxMetaGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uxMetaGrid.Location = New System.Drawing.Point(0, 48)
        '
        '
        '
        Me.uxMetaGrid.MasterTemplate.EnableGrouping = False
        Me.uxMetaGrid.MasterTemplate.PageSize = 200
        Me.uxMetaGrid.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.uxMetaGrid.Name = "uxMetaGrid"
        Me.uxMetaGrid.Size = New System.Drawing.Size(1090, 530)
        Me.uxMetaGrid.TabIndex = 0
        '
        'uxFilter
        '
        Me.uxFilter.Dock = System.Windows.Forms.DockStyle.Left
        Me.uxFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.uxFilter.Location = New System.Drawing.Point(10, 10)
        Me.uxFilter.Name = "uxFilter"
        Me.uxFilter.NullText = "Filter"
        Me.uxFilter.Size = New System.Drawing.Size(302, 28)
        Me.uxFilter.TabIndex = 1
        '
        'uxSaveGridSettings
        '
        Me.uxSaveGridSettings.Dock = System.Windows.Forms.DockStyle.Right
        Me.uxSaveGridSettings.Location = New System.Drawing.Point(964, 10)
        Me.uxSaveGridSettings.Name = "uxSaveGridSettings"
        Me.uxSaveGridSettings.Size = New System.Drawing.Size(116, 28)
        Me.uxSaveGridSettings.TabIndex = 2
        Me.uxSaveGridSettings.Text = "Save Grid Settings"
        '
        'uxShowColumnChooser
        '
        Me.uxShowColumnChooser.Dock = System.Windows.Forms.DockStyle.Right
        Me.uxShowColumnChooser.Location = New System.Drawing.Point(848, 10)
        Me.uxShowColumnChooser.Name = "uxShowColumnChooser"
        Me.uxShowColumnChooser.Size = New System.Drawing.Size(116, 28)
        Me.uxShowColumnChooser.TabIndex = 3
        Me.uxShowColumnChooser.Text = "Column Chooser"
        '
        'RadPanel1
        '
        Me.RadPanel1.AutoSize = True
        Me.RadPanel1.Controls.Add(Me.uxShowColumnChooser)
        Me.RadPanel1.Controls.Add(Me.uxSaveGridSettings)
        Me.RadPanel1.Controls.Add(Me.uxFilter)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.RadPanel1.Size = New System.Drawing.Size(1090, 48)
        Me.RadPanel1.TabIndex = 2
        Me.RadPanel1.Text = "RadPanel1"
        '
        'MetaRadGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.uxMetaGrid)
        Me.Controls.Add(Me.RadPanel1)
        Me.Name = "MetaRadGrid"
        Me.Size = New System.Drawing.Size(1090, 578)
        CType(Me.uxMetaGrid.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uxMetaGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uxFilter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uxSaveGridSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uxShowColumnChooser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uxMetaGrid As Telerik.WinControls.UI.RadGridView
    Friend WithEvents uxFilter As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents uxSaveGridSettings As Telerik.WinControls.UI.RadButton
    Friend WithEvents uxShowColumnChooser As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel

End Class
