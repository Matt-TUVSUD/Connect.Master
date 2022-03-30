<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CopeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CopeForm))
        Me.uxFilePrefix = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.uxGo = New Telerik.WinControls.UI.RadButton()
        Me.RadDataEntry1 = New Telerik.WinControls.UI.RadDataEntry()
        Me.uxMgmtComment = New Telerik.WinControls.UI.RadTextBox()
        Me.uxRecID = New Telerik.WinControls.UI.RadTextBox()
        Me.uxRecKeyWord = New Telerik.WinControls.UI.RadTextBox()
        Me.uxFileNo = New Telerik.WinControls.UI.RadTextBox()
        Me.uxPlantComment = New Telerik.WinControls.UI.RadTextBox()
        Me.RadBindingNavigator1 = New Telerik.WinControls.UI.RadBindingNavigator()
        Me.RadBindingNavigator1RowElement = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.RadBindingNavigator1FirstStrip = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.RadBindingNavigator1MoveFirstItem = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadBindingNavigator1MovePreviousItem = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadBindingNavigator1PositionItem = New Telerik.WinControls.UI.CommandBarTextBox()
        Me.RadBindingNavigator1CountItem = New Telerik.WinControls.UI.CommandBarLabel()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadBindingNavigator1MoveNextItem = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadBindingNavigator1MoveLastItem = New Telerik.WinControls.UI.CommandBarButton()
        Me.RadBindingNavigator1SecondStrip = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.RadBindingNavigator1AddNewItem = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator5 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.RadBindingNavigator1DeleteItem = New Telerik.WinControls.UI.CommandBarButton()
        Me.uxChars = New System.Windows.Forms.TextBox()
        Me.uxKeyWorkChars = New System.Windows.Forms.TextBox()
        Me.uxGoOccupancy = New Telerik.WinControls.UI.RadButton()
        CType(Me.uxFilePrefix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uxGo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDataEntry1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDataEntry1.PanelContainer.SuspendLayout()
        Me.RadDataEntry1.SuspendLayout()
        CType(Me.uxMgmtComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uxRecID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uxRecKeyWord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uxFileNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uxPlantComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadBindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uxGoOccupancy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uxFilePrefix
        '
        Me.uxFilePrefix.Location = New System.Drawing.Point(12, 57)
        Me.uxFilePrefix.Name = "uxFilePrefix"
        Me.uxFilePrefix.Size = New System.Drawing.Size(125, 20)
        Me.uxFilePrefix.TabIndex = 1
        Me.uxFilePrefix.Text = "Enter File Prefix"
        '
        'uxGo
        '
        Me.uxGo.Location = New System.Drawing.Point(143, 57)
        Me.uxGo.Name = "uxGo"
        Me.uxGo.Size = New System.Drawing.Size(71, 24)
        Me.uxGo.TabIndex = 2
        Me.uxGo.Text = "Go"
        '
        'RadDataEntry1
        '
        Me.RadDataEntry1.Location = New System.Drawing.Point(12, 82)
        Me.RadDataEntry1.Name = "RadDataEntry1"
        '
        'RadDataEntry1.PanelContainer
        '
        Me.RadDataEntry1.PanelContainer.Controls.Add(Me.uxMgmtComment)
        Me.RadDataEntry1.PanelContainer.Controls.Add(Me.uxRecID)
        Me.RadDataEntry1.PanelContainer.Controls.Add(Me.uxRecKeyWord)
        Me.RadDataEntry1.PanelContainer.Controls.Add(Me.uxFileNo)
        Me.RadDataEntry1.PanelContainer.Controls.Add(Me.uxPlantComment)
        Me.RadDataEntry1.PanelContainer.Size = New System.Drawing.Size(469, 389)
        Me.RadDataEntry1.Size = New System.Drawing.Size(487, 391)
        Me.RadDataEntry1.TabIndex = 3
        Me.RadDataEntry1.Text = "RadDataEntry1"
        '
        'uxMgmtComment
        '
        Me.uxMgmtComment.AutoSize = False
        Me.uxMgmtComment.Location = New System.Drawing.Point(20, 247)
        Me.uxMgmtComment.Multiline = True
        Me.uxMgmtComment.Name = "uxMgmtComment"
        Me.uxMgmtComment.Size = New System.Drawing.Size(444, 156)
        Me.uxMgmtComment.TabIndex = 3
        '
        'uxRecID
        '
        Me.uxRecID.Location = New System.Drawing.Point(20, 5)
        Me.uxRecID.Name = "uxRecID"
        Me.uxRecID.Size = New System.Drawing.Size(104, 20)
        Me.uxRecID.TabIndex = 2
        '
        'uxRecKeyWord
        '
        Me.uxRecKeyWord.Location = New System.Drawing.Point(20, 57)
        Me.uxRecKeyWord.Name = "uxRecKeyWord"
        Me.uxRecKeyWord.Size = New System.Drawing.Size(444, 20)
        Me.uxRecKeyWord.TabIndex = 2
        '
        'uxFileNo
        '
        Me.uxFileNo.Location = New System.Drawing.Point(20, 31)
        Me.uxFileNo.Name = "uxFileNo"
        Me.uxFileNo.Size = New System.Drawing.Size(104, 20)
        Me.uxFileNo.TabIndex = 1
        '
        'uxPlantComment
        '
        Me.uxPlantComment.AutoSize = False
        Me.uxPlantComment.Location = New System.Drawing.Point(20, 83)
        Me.uxPlantComment.Multiline = True
        Me.uxPlantComment.Name = "uxPlantComment"
        Me.uxPlantComment.Size = New System.Drawing.Size(444, 156)
        Me.uxPlantComment.TabIndex = 0
        '
        'RadBindingNavigator1
        '
        Me.RadBindingNavigator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadBindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.RadBindingNavigator1.Name = "RadBindingNavigator1"
        Me.RadBindingNavigator1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.RadBindingNavigator1RowElement})
        Me.RadBindingNavigator1.Size = New System.Drawing.Size(826, 30)
        Me.RadBindingNavigator1.TabIndex = 5
        Me.RadBindingNavigator1.Text = "RadBindingNavigator1"
        '
        'RadBindingNavigator1RowElement
        '
        Me.RadBindingNavigator1RowElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadBindingNavigator1RowElement.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.RadBindingNavigator1FirstStrip, Me.RadBindingNavigator1SecondStrip})
        '
        'RadBindingNavigator1FirstStrip
        '
        Me.RadBindingNavigator1FirstStrip.DisplayName = "RadBindingNavigator1FirstStrip"
        Me.RadBindingNavigator1FirstStrip.EnableDragging = False
        '
        '
        '
        Me.RadBindingNavigator1FirstStrip.Grip.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        Me.RadBindingNavigator1FirstStrip.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.RadBindingNavigator1MoveFirstItem, Me.CommandBarSeparator1, Me.RadBindingNavigator1MovePreviousItem, Me.CommandBarSeparator2, Me.RadBindingNavigator1PositionItem, Me.RadBindingNavigator1CountItem, Me.CommandBarSeparator3, Me.RadBindingNavigator1MoveNextItem, Me.CommandBarSeparator4, Me.RadBindingNavigator1MoveLastItem})
        Me.RadBindingNavigator1FirstStrip.MinSize = New System.Drawing.Size(0, 0)
        '
        '
        '
        Me.RadBindingNavigator1FirstStrip.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.RadBindingNavigator1FirstStrip.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.RadBindingNavigator1FirstStrip.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'RadBindingNavigator1MoveFirstItem
        '
        Me.RadBindingNavigator1MoveFirstItem.Image = CType(resources.GetObject("RadBindingNavigator1MoveFirstItem.Image"), System.Drawing.Image)
        Me.RadBindingNavigator1MoveFirstItem.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RadBindingNavigator1MoveFirstItem.Name = "RadBindingNavigator1MoveFirstItem"
        '
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
        '
        'RadBindingNavigator1MovePreviousItem
        '
        Me.RadBindingNavigator1MovePreviousItem.Image = CType(resources.GetObject("RadBindingNavigator1MovePreviousItem.Image"), System.Drawing.Image)
        Me.RadBindingNavigator1MovePreviousItem.Name = "RadBindingNavigator1MovePreviousItem"
        '
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'RadBindingNavigator1PositionItem
        '
        Me.RadBindingNavigator1PositionItem.Name = "RadBindingNavigator1PositionItem"
        '
        'RadBindingNavigator1CountItem
        '
        Me.RadBindingNavigator1CountItem.Name = "RadBindingNavigator1CountItem"
        Me.RadBindingNavigator1CountItem.Text = "of {0}"
        '
        'CommandBarSeparator3
        '
        Me.CommandBarSeparator3.Name = "CommandBarSeparator3"
        Me.CommandBarSeparator3.VisibleInOverflowMenu = False
        '
        'RadBindingNavigator1MoveNextItem
        '
        Me.RadBindingNavigator1MoveNextItem.Image = CType(resources.GetObject("RadBindingNavigator1MoveNextItem.Image"), System.Drawing.Image)
        Me.RadBindingNavigator1MoveNextItem.Name = "RadBindingNavigator1MoveNextItem"
        '
        'CommandBarSeparator4
        '
        Me.CommandBarSeparator4.Name = "CommandBarSeparator4"
        Me.CommandBarSeparator4.VisibleInOverflowMenu = False
        '
        'RadBindingNavigator1MoveLastItem
        '
        Me.RadBindingNavigator1MoveLastItem.Image = CType(resources.GetObject("RadBindingNavigator1MoveLastItem.Image"), System.Drawing.Image)
        Me.RadBindingNavigator1MoveLastItem.Name = "RadBindingNavigator1MoveLastItem"
        '
        'RadBindingNavigator1SecondStrip
        '
        Me.RadBindingNavigator1SecondStrip.DisplayName = "RadBindingNavigator1SecondStrip"
        Me.RadBindingNavigator1SecondStrip.EnableDragging = False
        '
        '
        '
        Me.RadBindingNavigator1SecondStrip.Grip.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        Me.RadBindingNavigator1SecondStrip.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.RadBindingNavigator1AddNewItem, Me.CommandBarSeparator5, Me.RadBindingNavigator1DeleteItem})
        Me.RadBindingNavigator1SecondStrip.MinSize = New System.Drawing.Size(0, 0)
        '
        '
        '
        Me.RadBindingNavigator1SecondStrip.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.RadBindingNavigator1SecondStrip.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.RadBindingNavigator1SecondStrip.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'RadBindingNavigator1AddNewItem
        '
        Me.RadBindingNavigator1AddNewItem.Image = CType(resources.GetObject("RadBindingNavigator1AddNewItem.Image"), System.Drawing.Image)
        Me.RadBindingNavigator1AddNewItem.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RadBindingNavigator1AddNewItem.Name = "RadBindingNavigator1AddNewItem"
        '
        'CommandBarSeparator5
        '
        Me.CommandBarSeparator5.Name = "CommandBarSeparator5"
        Me.CommandBarSeparator5.VisibleInOverflowMenu = False
        '
        'RadBindingNavigator1DeleteItem
        '
        Me.RadBindingNavigator1DeleteItem.Image = CType(resources.GetObject("RadBindingNavigator1DeleteItem.Image"), System.Drawing.Image)
        Me.RadBindingNavigator1DeleteItem.Name = "RadBindingNavigator1DeleteItem"
        '
        'uxChars
        '
        Me.uxChars.Location = New System.Drawing.Point(506, 82)
        Me.uxChars.Multiline = True
        Me.uxChars.Name = "uxChars"
        Me.uxChars.Size = New System.Drawing.Size(144, 299)
        Me.uxChars.TabIndex = 6
        '
        'uxKeyWorkChars
        '
        Me.uxKeyWorkChars.Location = New System.Drawing.Point(656, 83)
        Me.uxKeyWorkChars.Multiline = True
        Me.uxKeyWorkChars.Name = "uxKeyWorkChars"
        Me.uxKeyWorkChars.Size = New System.Drawing.Size(144, 299)
        Me.uxKeyWorkChars.TabIndex = 7
        '
        'uxGoOccupancy
        '
        Me.uxGoOccupancy.Location = New System.Drawing.Point(220, 57)
        Me.uxGoOccupancy.Name = "uxGoOccupancy"
        Me.uxGoOccupancy.Size = New System.Drawing.Size(141, 24)
        Me.uxGoOccupancy.TabIndex = 3
        Me.uxGoOccupancy.Text = "Go (Occupany)"
        '
        'CopeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 498)
        Me.Controls.Add(Me.uxGoOccupancy)
        Me.Controls.Add(Me.uxKeyWorkChars)
        Me.Controls.Add(Me.uxChars)
        Me.Controls.Add(Me.RadBindingNavigator1)
        Me.Controls.Add(Me.RadDataEntry1)
        Me.Controls.Add(Me.uxGo)
        Me.Controls.Add(Me.uxFilePrefix)
        Me.Name = "CopeForm"
        Me.Text = "Cope Form"
        CType(Me.uxFilePrefix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uxGo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDataEntry1.PanelContainer.ResumeLayout(False)
        Me.RadDataEntry1.PanelContainer.PerformLayout()
        CType(Me.RadDataEntry1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDataEntry1.ResumeLayout(False)
        CType(Me.uxMgmtComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uxRecID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uxRecKeyWord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uxFileNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uxPlantComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadBindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uxGoOccupancy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents uxFilePrefix As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents uxGo As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadDataEntry1 As Telerik.WinControls.UI.RadDataEntry
    Friend WithEvents RadBindingNavigator1 As Telerik.WinControls.UI.RadBindingNavigator
    Friend WithEvents RadBindingNavigator1RowElement As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents RadBindingNavigator1FirstStrip As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents RadBindingNavigator1MoveFirstItem As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadBindingNavigator1MovePreviousItem As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadBindingNavigator1PositionItem As Telerik.WinControls.UI.CommandBarTextBox
    Friend WithEvents RadBindingNavigator1CountItem As Telerik.WinControls.UI.CommandBarLabel
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadBindingNavigator1MoveNextItem As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadBindingNavigator1MoveLastItem As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents RadBindingNavigator1SecondStrip As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents RadBindingNavigator1AddNewItem As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator5 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RadBindingNavigator1DeleteItem As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents uxPlantComment As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents uxRecKeyWord As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents uxFileNo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents uxRecID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents uxChars As System.Windows.Forms.TextBox
    Friend WithEvents uxKeyWorkChars As System.Windows.Forms.TextBox
    Friend WithEvents uxMgmtComment As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents uxGoOccupancy As Telerik.WinControls.UI.RadButton
End Class
