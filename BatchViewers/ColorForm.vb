Public Class ColorForm
    Implements IUtilityForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

    
    End Sub

    Public ReadOnly Property ShowOnMainMenu As Boolean Implements IUtilityForm.ShowOnMainMenu
        Get
            Return True
        End Get
    End Property

    Private Sub RadGridView1_RowFormatting(sender As Object, e As Telerik.WinControls.UI.RowFormattingEventArgs) Handles RadGridView1.RowFormatting
        Dim zColor As razor.rowVwMetaColor = e.RowElement.Data.DataBoundItem

        e.RowElement.DrawFill = True
        e.RowElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        e.RowElement.BackColor = System.Drawing.ColorTranslator.FromHtml(zColor.colFldHex)
        e.RowElement.ForeColor = System.Drawing.ColorTranslator.FromHtml(zColor.colUseForeColorHex)
    End Sub

    Private Sub ColorForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Add any initialization after the InitializeComponent() call.
        RadGridView1.DataSource = razor.VwMetaColor.LoadData

    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        RadGridView1.DataSource = razor.VwMetaColor.LoadData
        RadGridView1.Refresh()
    End Sub
End Class