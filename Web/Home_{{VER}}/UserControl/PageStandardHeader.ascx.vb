Public Class PageStandardHeader
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Property Header() As String
        Get
            Return lblHeader.Text
        End Get
        Set(Value As String)
            lblHeader.Text = Value
        End Set
    End Property

    Public WriteOnly Property SubHeader() As String
        Set(Value As String)
            lblSubHeader.Text = Value
        End Set
    End Property

    Public WriteOnly Property CanClose() As Boolean
        Set(Value As Boolean)
            btnClose.Visible = Value
        End Set
    End Property

End Class