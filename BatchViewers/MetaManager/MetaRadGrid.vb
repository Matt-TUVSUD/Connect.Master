Imports Telerik.WinControls.UI
Imports System.Reflection
Imports Telerik.WinControls

Public Class MetaRadGrid

    Private WithEvents _ContextMenuStrip As New ColumnsListContextMenuStrip(Me)
    Private WithEvents _Notification As New RadDesktopAlert()
    Private _DataSourceType As Type

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        uxMetaGrid.AutoGenerateColumns = True
        uxMetaGrid.AutoScroll = True
        uxMetaGrid.AllowAutoSizeColumns = True
        uxMetaGrid.BestFitColumns()
        uxMetaGrid.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        uxMetaGrid.HorizontalScrollState = ScrollState.AutoHide
        uxMetaGrid.AllowColumnChooser = True
        uxMetaGrid.MasterTemplate.AllowColumnChooser = True
        uxMetaGrid.EnableFiltering = True
        uxMetaGrid.ContextMenuStrip = _ContextMenuStrip

        _Notification.AutoClose = True
        _Notification.AutoCloseDelay = 2
        _Notification.PopupAnimationEasing = RadEasingType.InBack
        _Notification.PopupAnimationFrames = 10
        _Notification.ScreenPosition = AlertScreenPosition.Manual
        _Notification.ShowCloseButton = True
        _Notification.ShowPinButton = False
        _Notification.ShowOptionsButton = False
        _Notification.FixedSize = New System.Drawing.Size(300, 100)
        _Notification.Popup.Location = New System.Drawing.Point((System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - _Notification.FixedSize.Width) / 2, (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - _Notification.FixedSize.Height) / 2)

    End Sub

    Public ReadOnly Property FilterTextBox As RadTextBoxControl
        Get
            Return uxFilter
        End Get
    End Property

    Public ReadOnly Property MetaGrid As RadGridView
        Get
            Return uxMetaGrid
        End Get
    End Property

    Public Property DataSource As Object
        Get
            Return uxMetaGrid.DataSource
        End Get
        Set(value As Object)
            uxMetaGrid.DataSource = value
        End Set
    End Property

    Private Sub uxMetaGrid_ContextMenuOpening(sender As Object, e As ContextMenuOpeningEventArgs) Handles uxMetaGrid.ContextMenuOpening
        If TypeOf e.ContextMenuProvider Is GridHeaderCellElement Then
            Dim zItem As New RadMenuItem
            zItem.Text = "Rename"
            zItem.Tag = DirectCast(e.ContextMenuProvider, GridHeaderCellElement).ColumnInfo
            AddHandler zItem.Click, AddressOf RenameColumnHandler

            e.ContextMenu.Items.Add(zItem)
        End If
    End Sub

    Private Sub uxMetaGrid_DataBindingComplete(sender As Object, e As GridViewBindingCompleteEventArgs) Handles uxMetaGrid.DataBindingComplete
        Try
            ApplyGridSettings()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub uxSaveGridSettings_Click(sender As Object, e As EventArgs) Handles uxSaveGridSettings.Click
        Try
            SaveGridSettings()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ApplyGridSettings()
        Dim _DataSourceType As Type = DirectCast(uxMetaGrid.DataSource, IList).GetType.GetGenericArguments.First
        Dim zPath As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "GRC\Meta Manager App\GridSettings\" & _DataSourceType.ToString & ".json")

        If IO.File.Exists(zPath) Then
            Dim zJSON As String = IO.File.ReadAllText(zPath)
            Dim zColSettingList As List(Of GridColumnSetting) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of GridColumnSetting))(zJSON)
            For Each zSetting As GridColumnSetting In zColSettingList
                Dim zGridCol As GridViewDataColumn = uxMetaGrid.Columns(zSetting.Name)
                If Not IsNothing(zGridCol) Then
                    uxMetaGrid.Columns.Move(zGridCol.Index, zSetting.Position)
                End If
            Next

            For Each zCol As GridViewDataColumn In uxMetaGrid.Columns
                Dim zSetting As GridColumnSetting = zColSettingList.Find(Function(x) x.Name = zCol.Name)
                If Not IsNothing(zSetting) Then
                    zCol.IsVisible = zSetting.IsVisible
                    zCol.HeaderText = zSetting.HeaderText
                    zCol.Width = zSetting.Width
                End If
            Next

        End If
    End Sub

    Private Sub SaveGridSettings()

        _DataSourceType = DirectCast(uxMetaGrid.DataSource, IList).GetType.GetGenericArguments.First
        Dim zPath As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "GRC\Meta Manager App\GridSettings\" & _DataSourceType.ToString & ".json")
        Dim zSettingsList As New List(Of GridColumnSetting)
        uxMetaGrid.Columns.ToList.ForEach(Sub(x) zSettingsList.Add(New GridColumnSetting(x.Name, x.HeaderText, x.Width, x.IsVisible, x.Index)))
        Dim zJSON As String = Newtonsoft.Json.JsonConvert.SerializeObject(zSettingsList, Newtonsoft.Json.Formatting.Indented)

        If Not IO.Directory.Exists(IO.Path.GetDirectoryName(zPath)) Then IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(zPath))
        '  If Not IO.File.Exists(zPath) Then IO.File.(zPath)
        IO.File.WriteAllText(zPath, zJSON)

        Notify("Saved!", "Settings have been saved.")
    End Sub

    Private Sub uxShowColumnChooser_Click(sender As Object, e As EventArgs) Handles uxShowColumnChooser.Click
        uxMetaGrid.ShowColumnChooser()
    End Sub

    Private Sub RenameColumnHandler(sender As Object, e As EventArgs)
        Dim zMenuItem As RadMenuItem = sender
        Dim zColInfo As GridViewColumn = zMenuItem.Tag
        Dim zName As String = InputBox("Rename [" & zColInfo.HeaderText & "] to:", "Rename")
        If zName.Length > 0 Then
            zColInfo.HeaderText = zName
        End If
    End Sub

    Public Sub Notify(pCaptionText As String, pMessage As String)

        _Notification.CaptionText = pCaptionText
        _Notification.ContentText = pMessage
        _Notification.Show()
    End Sub

    Private Sub uxFilter_TextChanging(sender As Object, e As TextChangingEventArgs) Handles uxFilter.TextChanging
        If (uxFilter.Text & e.NewValue).Length > 0 Then

            '    iList.
            '    'For Each zCol As GridViewDataColumn In uxMetaGrid.Columns
            '    '    If zCol.IsVisible Then
            '    '        If TypeOf zCol Is GridViewTextBoxColumn Then
            '    '            zCol.FilterDescriptor = New Telerik.WinControls.Data.FilterDescriptor
            '    '            zCol.FilterDescriptor.Operator = Telerik.WinControls.Data.FilterOperator.Contains
            '    '            zCol.FilterDescriptor.Value = uxFilter.Text & e.NewValue
            '    '            uxMetaGrid.FilterDescriptors.Add(zCol.FilterDescriptor)
            '    '            '     uxMetaGrid.Refresh()
            '    '            Dim zFilteredCount As Integer = uxMetaGrid.ChildRows.Count
            '    '        End If
            '    '    End If
            '    'Next
            'Else
            '    uxMetaGrid.FilterDescriptors.Clear()
        End If
    End Sub

End Class


Friend Class ColumnsListViewDataItem
    Inherits ListViewDataItem

    Private _DataColumn As GridViewDataColumn

    Public Sub New(pText As String, pDataColumn As GridViewDataColumn)
        Me.Text = pText
        Me._DataColumn = pDataColumn
    End Sub

    Public Property DataColumn As GridViewDataColumn
        Get
            Return _DataColumn
        End Get
        Set(value As GridViewDataColumn)
            _DataColumn = value
        End Set
    End Property

End Class

Friend Class ColumnsListContextMenuStrip
    Inherits System.Windows.Forms.ContextMenuStrip

    Private _Parent As MetaRadGrid = Nothing

    Friend Sub New(pParent As MetaRadGrid)
        _Parent = pParent
        Me.Items.Add("Set Meta")
    End Sub

End Class

Public Class GridColumnSetting
    Public Name As String
    Public HeaderText As String
    Public Width As Integer
    Public IsVisible As Boolean
    Public Position As Integer

    Public Sub New(pName As String, pHeaderText As String, pWidth As Integer, pIsVisible As Boolean, pPosition As Integer)
        Me.Name = pName
        Me.HeaderText = pHeaderText
        Me.Width = pWidth
        Me.IsVisible = pIsVisible
        Me.Position = pPosition
    End Sub
End Class

