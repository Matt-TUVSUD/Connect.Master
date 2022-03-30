<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CharFinderForm
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
        Me.uxTable = New Telerik.WinControls.UI.RadDropDownList()
        Me.uxFilePrefix = New Telerik.WinControls.UI.RadTextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.uxTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uxFilePrefix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uxTable
        '
        Me.uxTable.Location = New System.Drawing.Point(12, 41)
        Me.uxTable.Name = "uxTable"
        Me.uxTable.Size = New System.Drawing.Size(256, 20)
        Me.uxTable.TabIndex = 0
        '
        'uxFilePrefix
        '
        Me.uxFilePrefix.Location = New System.Drawing.Point(12, 15)
        Me.uxFilePrefix.Name = "uxFilePrefix"
        Me.uxFilePrefix.Size = New System.Drawing.Size(100, 20)
        Me.uxFilePrefix.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(13, 68)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(420, 304)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'CharFinderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 395)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.uxFilePrefix)
        Me.Controls.Add(Me.uxTable)
        Me.Name = "CharFinderForm"
        Me.Text = "CharFinderForm"
        CType(Me.uxTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uxFilePrefix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uxTable As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents uxFilePrefix As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
End Class
