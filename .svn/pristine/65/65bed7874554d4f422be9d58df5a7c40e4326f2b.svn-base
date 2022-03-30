Public Class MetaPropertyForm
    Implements IUtilityForm

    Public MetaIDColumn As Meta.IMetaIDColumn

    Friend Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(pOwner As Windows.Forms.Form)
        Me.New()
        Me.Owner = pOwner
    End Sub

    Public Sub LoadProperties(pColumn As Meta.IMetaIDColumn, pID As Integer?)
        Telerik.WinControls.ThemeResolutionService.ApplicationThemeName = DirectCast(Owner, MetaUtilityForm).DefaultTheme
        Me.RadPropertyGrid1.SelectedObject = pColumn.GetPropertyStore(pID)
        Me.TopMost = True
        If Me.Visible = False Then Me.Show()
        RadPropertyGrid1.Refresh()
    End Sub

    Public ReadOnly Property ShowOnMainMenu As Boolean Implements IUtilityForm.ShowOnMainMenu
        Get
            Return False
        End Get
    End Property
End Class