Imports System.Windows.Forms

Namespace Meta
    Public Class MetaToolTip
        Inherits Telerik.WinControls.RadToolTip

        Public Sub New()
            Me.OwnerDraw = True
            Me.UseAnimation = True
            Me.IsBalloon = False
            AddHandler Me.Draw, AddressOf OnDraw
        End Sub

        Private Sub OnDraw(ByVal sender As Object, ByVal e As DrawToolTipEventArgs)
            Dim zRect As New System.Drawing.Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width + 50, e.Bounds.Height)
            Dim newArgs As DrawToolTipEventArgs = New DrawToolTipEventArgs(e.Graphics, e.AssociatedWindow, e.AssociatedControl, zRect, e.ToolTipText, Me.BackColor, Me.ForeColor, ToolTipFont)
            newArgs.DrawBackground()
            newArgs.DrawBorder()
            newArgs.DrawText(TextFormatFlags.WordBreak Or TextFormatFlags.Left Or TextFormatFlags.Top Or TextFormatFlags.LeftAndRightPadding)
        End Sub

        Private Shadows ReadOnly Property ToolTipFont
            Get
                Return New System.Drawing.Font("Consolas", 8)
            End Get
        End Property

        Private Sub MetaToolTip_Popup(sender As Object, e As PopupEventArgs) Handles Me.Popup

        End Sub
    End Class
End Namespace
